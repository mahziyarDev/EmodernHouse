using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Order;
using EModernHouse.DataLayer.Entities.Account;
using EModernHouse.DataLayer.Entities.ProductOrder;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface IOrderService : IAsyncDisposable
    {
        #region Order

        Task<List<Order>> GetAllOrder(long userId);
        Task<long> AddOrderForUser(long userId);
        Task<Order> GetUserLatestOpenOrder(long userId);
        Task<int> GetTotalOrderPriceForPayment(long userId);
        Task PayOrderProductPriceToSeller(long userId);
        #endregion

        #region OrderDetail

        Task AddProductToOpenOrder(AddProductToOrderDTO order, long userId);
        Task<List<OrderDetail>> GetOrderDetailById(long orderId);
        Task<bool> RemoveOrderDetail(long detailId,long userId);
        Task ChangeOpenOrder(long detailId, long userId, int count);
        Task<bool> ExistProductColor(long detailId, int count,long userId);

        #endregion
    }
}