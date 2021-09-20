using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Product;
using EModernHouse.DataLayer.Entities.Product;
using EModernHouse.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EModernHouse.Application.Services.Implementations
{
    public class ProductService : IProductService
    {
        #region Ctor

        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<ProductCategory> _productCategoryRepository;
        private readonly IGenericRepository<ProductSelectedCategory> _productSelectedCategoryRepository;
        private readonly IGenericRepository<ProductColor> _productColorRepository;

        public ProductService(IGenericRepository<Product> productRepository, IGenericRepository<ProductCategory> productCategoryRepository, IGenericRepository<ProductSelectedCategory> productSelectedCategoryRepository, IGenericRepository<ProductColor> productColorRepository)
        {
            _productRepository = productRepository;
            _productCategoryRepository = productCategoryRepository;
            _productSelectedCategoryRepository = productSelectedCategoryRepository;
            _productColorRepository = productColorRepository;
        }

        #endregion

        #region Product

        public async Task<bool> CreateProduct(CreateProductDTO create, string imageName)
        {
            //create product 
            var newProduct = new Product
            {
                Title = create.Title,
                ShortDescription = create.ShortDescription,
                Description = create.Description,
                IsActive = create.IsActive,
                Price = create.Price,
                ImageName = imageName,

            };
            await _productRepository.AddEntity(newProduct);
            await _productRepository.SaveChanges();

            //Create Categories

            //create product color  
            return true;

        }

        #endregion

        #region Product-Categories

        public async Task<List<ProductCategory>> GetAllProductCategoriesByParentId(long? parentId)
        {
            if (parentId == null || parentId == 0)
            {
                return await _productCategoryRepository.GetQuery().AsQueryable()
                    .Where(s => s.IsActive && !s.IsDelete && s.ParentId == null)
                    .ToListAsync();
            }

            return await _productCategoryRepository.GetQuery().AsQueryable()
                .Where(s => !s.IsDelete && s.IsActive && s.ParentId == parentId)
                .ToListAsync();
        }

        public async Task<List<ProductCategory>> GetAllActiveProductCategories()
        {
            return await _productCategoryRepository.GetQuery().AsQueryable()
                .Where(s => !s.IsDelete && s.IsActive).ToListAsync();
        }
        #endregion



        #region Disposiable

        public async ValueTask DisposeAsync()
        {
            await _productRepository.DisposeAsync();
            await _productColorRepository.DisposeAsync();
            await _productCategoryRepository.DisposeAsync();
            await _productSelectedCategoryRepository.DisposeAsync();
        }

        #endregion
    }
}