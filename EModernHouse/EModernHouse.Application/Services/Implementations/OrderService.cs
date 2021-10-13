using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Order;
using EModernHouse.DataLayer.Entities.ProductOrder;
using EModernHouse.DataLayer.Repository;
using LazZiya.ImageResize.Animated;
using Microsoft.EntityFrameworkCore;

namespace EModernHouse.Application.Services.Implementations
{
    public class OrderService : IOrderService
    {
        #region Ctor

        private readonly IGenericRepository<Order> _orderRepository;
        private readonly IGenericRepository<OrderDetail> _orderDetailRepository;

        public OrderService(IGenericRepository<Order> orderRepository, IGenericRepository<OrderDetail> orderDetailRepository)
        {
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
        }

        #endregion

        #region Order

        public async Task<List<Order>> GetAllOrder(long userId)
        {
            var ordersForUser = await _orderRepository.GetQuery().AsQueryable()
                .Where(s => s.UserId == userId).ToListAsync();
            return ordersForUser;
        }

        public async Task<long> AddOrderForUser(long userId)
        {
            var newOrder = new Order
            {
                UserId = userId,
            };
            await _orderRepository.AddEntity(newOrder);
            await _orderRepository.SaveChanges();
            return newOrder.Id;
        }

        public async Task<Order> GetUserLatestOpenOrder(long userId)
        {
            if (!await _orderRepository.GetQuery().AnyAsync(s=>s.UserId == userId && !s.IsPaid))
            {
                await AddOrderForUser(userId);
            }

            var userOrderOpen =await _orderRepository.GetQuery().AsQueryable()
                .Include(s=>s.OrderDetails)
                .ThenInclude(s=>s.ProductColor)
                .Include(s=>s.OrderDetails)
                .ThenInclude(s=>s.Product)
                .SingleOrDefaultAsync(s => s.UserId == userId && !s.IsPaid);
            return userOrderOpen;
        }

        #endregion

        #region OrderDetail

        public async Task AddProductToOpenOrder(AddProductToOrderDTO order,long userId)
        {
            var openOrder = await GetUserLatestOpenOrder(userId);
            var similarOrder = openOrder.OrderDetails.SingleOrDefault(s =>
                s.ProductId == order.ProductId && s.ProductColorId == order.ProductColorId);

            if (similarOrder == null)
            {
                var orderDetail = new OrderDetail
                {
                    OrderId = openOrder.Id,
                    ProductId = order.ProductId,
                    ProductColorId = order.ProductColorId,
                    Count = order.Count
                };
                await _orderDetailRepository.AddEntity(orderDetail);
                await _orderDetailRepository.SaveChanges();
            }
            else
            {
                similarOrder.Count += order.Count;
                await _orderDetailRepository.SaveChanges();
            }
          

        }

        public async Task<List<OrderDetail>> GetOrderDetailById(long orderId)
        {
            var orderDetail = await _orderDetailRepository.GetQuery().AsQueryable()
                .Include(s=>s.Product)
                .Include(s => s.ProductColor)
             
                .ThenInclude(s => s.Product)
                .Include(s=>s.Order)
                .Where(s => s.OrderId == orderId)
                .ToListAsync();
            return orderDetail;
        }

        #endregion

        #region Dispose

        public async ValueTask DisposeAsync()
        {
            await _orderRepository.DisposeAsync();
            await _orderDetailRepository.DisposeAsync();
        }

        #endregion

    }
}