using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Filter;
using EModernHouse.DataLayer.DTOs.Product;
using EModernHouse.DataLayer.Entities.Product;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface IInventoryService : IAsyncDisposable
    {
        #region ForInventory

        Task<InventoryFilterDTO> GetProducyForInventory(int pageId, int take, string productName);
        Task<List<ProductColor>> ProductColors(long productId);
        Task<bool> InsertNumberCount(long colorId, int count);

        #endregion

        #region ForProductShowIndex

        Task<PopularProductsFilterDTO> GetPopularProducts(int pageId, int take);
        Task<bool> DeletePopular(long popularId);
        Task<bool> AddPopularProduct(ProductForShowIndex popular);

        #endregion
    }
}