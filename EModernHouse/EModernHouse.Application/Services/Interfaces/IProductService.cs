using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Filter;
using EModernHouse.DataLayer.DTOs.Product;
using EModernHouse.DataLayer.Entities.Product;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface IProductService : IAsyncDisposable
    {
        #region filterProduc

        Task<Tuple<List<Product>, int>> GetProductForFilter(int pageId, int take, string productName);
        #endregion

        #region Product

        Task<bool> CreateProduct(CreateProductDTO create, string imageName);
        Task<EditProductDTO> GetProductForEdit(long productId);
        Task<bool> EditProduct(EditProductDTO edit);
        #endregion

        #region Product-Categories

        Task<List<ProductCategory>> GetAllProductCategoriesByParentId(long? parentId);
        Task<List<ProductCategory>> GetAllActiveProductCategories();

        #endregion

        #region ProductGallery

        Task<bool> AddImageProductForGallery(CreateProductGalleryDTO gallery);
        Task<List<ProductGallery>> GetAllGalleryForProduct(long productID);
        Task<bool> EditProductGallery(long galleryId, int displayPriority, string alt,string newImage);
        Task<long> DeleteProductGalleryById(long galleryId);
        #endregion

        #region categories

        CategoriesFilterDTO GetCategoriesForList(int pageId, int take, string filter);
        Task<List<ProductCategory>> GetAllProductCategoriesForList();
        Task<bool> DeleteCategories(long id);
        Task<bool> CreateMainCategory(string name, string imageName);
        Task<EditProductCategoryDTO> GetMainCategoryForEdit(long categoryId);
        Task<bool> SetMainCategoryForEdit( EditProductCategoryDTO edit);
        Task<bool> CreateSubGroups(long groupId, string groupName);
        #endregion

        #region ProductColor

        Task<bool> CreateColorProduct(CreateProductColorDTO create);
        Task<List<ProductColor>> GetProductColorByproductId(long productId);
        Task<long> DeleteProductColorById(long colorId);
        Task<bool> EditProductColor(long colorId, string colorName, string colorCode, int price);

        #endregion

        #region ProductForClient

        Task<ProductUserFilterDTO> GetProductsForUsers(int pageId,int take,int startPrice,int endPrice,long? category);

        #endregion
    }
}