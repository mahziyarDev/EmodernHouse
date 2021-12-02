   using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Order;
   using EModernHouse.DataLayer.Entities.Product;
   using EModernHouse.DataLayer.Entities.ProductOrder;
using EModernHouse.DataLayer.Entities.Wallet;
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
        private readonly IWalletService _walletService;
        private readonly IGenericRepository<ProductColor> _productColorRepository;

        public OrderService(IGenericRepository<Order> orderRepository, IGenericRepository<OrderDetail> orderDetailRepository, IGenericRepository<SellerWallet> sellerWalletRepository, IWalletService walletService, IGenericRepository<ProductColor> productColorRepository)
        {
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
            _walletService = walletService;
            _productColorRepository = productColorRepository;
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
                .ThenInclude(s=>s.ProductDisCounts)
                .SingleOrDefaultAsync(s => s.UserId == userId && !s.IsPaid);
            return userOrderOpen;
        }

        public async Task<int> GetTotalOrderPriceForPayment(long userId)
        {
            var userOpenOrder = await GetUserLatestOpenOrder(userId);
            var totalPrice = 0;
            foreach (var detail in userOpenOrder.OrderDetails)
            {
                totalPrice += detail.Count * (detail.Product.Price + detail.ProductColor.Price);
            }

            return totalPrice;
        }

        public async Task PayOrderProductPriceToSeller(long userId)
        {
            var openOrder = await GetUserLatestOpenOrder(userId);
            foreach (var order in openOrder.OrderDetails)
            {
                var productPrice = order.Product.Price;
                var productColorPrice = order.ProductColor.Price;
                var discount = 0;
                var totalPrice = ((productPrice + productColorPrice) * order.Count) - discount ;
                await _walletService.AddWallet(new SellerWallet
                {
                    Price = (int) Math.Ceiling(totalPrice * 3 / (double)100),
                    TransactionType = TransactionType.Deposit,
                    Description = $"سود فروش {order.Product.Title} به مبلغ {(int)Math.Ceiling(totalPrice * 3 / (double)100)} و قیمت اصلی به مبلغ {totalPrice} با سهم 3 درصد واریز شد"
                });
            }
            //todo : send to payment
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

        public async Task<bool> RemoveOrderDetail(long detailId,long userId)
        {
            var openOrder = await GetUserLatestOpenOrder(userId);
            var orderDetail = openOrder.OrderDetails.SingleOrDefault(s => s.Id == detailId);
            if (orderDetail == null) return false;

            _orderDetailRepository.Delete(orderDetail);
            await _orderDetailRepository.SaveChanges();
            return true;
        }

        public async Task ChangeOpenOrder(long detailId, long userId, int count)
        {
            var openOrder =await GetUserLatestOpenOrder(userId);
            var detail = openOrder.OrderDetails.SingleOrDefault(s => s.Id == detailId);

            if (detail != null)
            {
                if (count > 0)
                {
                    detail.Count = count;
                    _orderDetailRepository.EditEntity(detail);
                    await _orderDetailRepository.SaveChanges();
                }
                else
                {
                    _orderDetailRepository.Delete(detail);
                    await _orderDetailRepository.SaveChanges();
                }
            }
        }

        public async Task<bool> ExistProductColor(long detailId, int count,long userId)
        {
            var openOrder = await GetUserLatestOpenOrder(userId);
            var detail =openOrder.OrderDetails.SingleOrDefault(s => s.Id == detailId);
            var color = await _productColorRepository.GetEntityById(detail.ProductColor.Id);

            if (color.Count >= count)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> ExistProductColorByColorId(long colorId, int count)
        {
            var color = await _productColorRepository.GetEntityById(colorId);
            if (color.Count < count)
            {
                return false;
            }

            return true;
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