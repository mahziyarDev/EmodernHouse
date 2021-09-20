using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Product;
using EModernHouse.DataLayer.Entities.Product;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface IProductService : IAsyncDisposable
    {
        #region Product

        Task<bool> CreateProduct(CreateProductDTO create, string imageName);

        #endregion

        #region Product-Categories

        Task<List<ProductCategory>> GetAllProductCategoriesByParentId(long? parentId);
        Task<List<ProductCategory>> GetAllActiveProductCategories();

        #endregion
    }
}