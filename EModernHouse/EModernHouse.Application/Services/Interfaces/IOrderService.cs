using System;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Order;
using EModernHouse.DataLayer.Entities.ProductOrder;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface IOrderService : IAsyncDisposable
    {
        #region Order

        Task<long> AddOrderForUser(long userId);
        Task<Order> GetUserLatestOpenOrder(long userId);

        #endregion

        #region OrderDetail

        Task AddProductToOpenOrder(AddProductToOrderDTO order, long userId);

        #endregion
    }
}