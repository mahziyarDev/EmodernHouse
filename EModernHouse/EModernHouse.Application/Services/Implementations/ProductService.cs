using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.Application.Utils;
using EModernHouse.DataLayer.DTOs.Product;
using EModernHouse.DataLayer.Entities.Product;
using EModernHouse.DataLayer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using EModernHouse.Application.Extensions;


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

            var productSelectedCategories = new List<ProductSelectedCategory>();

            foreach (var category in create.SelectedCategories)
            {
                productSelectedCategories.Add(new ProductSelectedCategory
                {
                    ProductCategoryId = category,
                    ProductId = newProduct.Id
                });
            }

            await _productSelectedCategoryRepository.AddRangeEntity(productSelectedCategories);
            await _productSelectedCategoryRepository.SaveChanges();

            //create product color  

            var productSelectedColor = new List<ProductColor>();

            foreach (var productColor in create.ProductColor)
            {
                productSelectedColor.Add( new ProductColor
                {
                    ProductId = newProduct.Id,
                    ColorName = productColor.ColorName,
                    ColorCode = productColor.ColorCode,
                    Price = productColor.Price
                });
            }

            await _productColorRepository.AddRangeEntity(productSelectedColor);
            await _productColorRepository.SaveChanges();
            return true;

        }

        public async Task<EditProductDTO> GetProductForEdit(long productId)
        {
            var product = await _productRepository.GetEntityById(productId);

            return new EditProductDTO
            {
                Id = productId,
                Title = product.Title,
                ShortDescription = product.ShortDescription,
                Description = product.Description,
                Price = product.Price,
                IsActive = product.IsActive,
                ProductColor = await _productColorRepository.GetQuery().AsQueryable()
                    .Where(s=>!s.IsDelete&&s.ProductId==productId)
                    .Select(s=>new CreateProductColorDTO{ColorName = s.ColorName,ColorCode = s.ColorCode,Price = s.Price})
                    .ToListAsync(),
                SelectedCategories = await _productSelectedCategoryRepository
                    .GetQuery().AsQueryable()
                    .Where(s=>!s.IsDelete&&s.ProductId == productId)
                    .Select(s=>s.ProductCategoryId)
                    .ToListAsync(),
                ImageNameProduct = product.ImageName

            };
        }

        public async Task<bool> EditProduct(EditProductDTO edit)
        {
            var product = await _productRepository.GetEntityById(edit.Id);
            if (product == null)
            {
                return false;
            }
             
            product.Title = edit.Title;
            product.ShortDescription = edit.ShortDescription;
            product.Description = edit.Description;
            product.Price = edit.Price;
            product.ImageName = edit.ImageNameProduct;
            product.IsActive = edit.IsActive;
            
            _productRepository.EditEntity(product);
            await _productRepository.SaveChanges();
            //for remove all selected categories
            _productSelectedCategoryRepository.DeletePermanentRange(await _productSelectedCategoryRepository
                .GetQuery().AsQueryable()
                .Where(s=>s.ProductId == product.Id).ToListAsync());
            //for new categories
            var productSelectedCategories = new List<ProductSelectedCategory>();

            foreach (var category in edit.SelectedCategories)
            {
                productSelectedCategories.Add(new ProductSelectedCategory
                {
                    ProductCategoryId = category,
                    ProductId = product.Id
                });
            }

            await _productSelectedCategoryRepository.AddRangeEntity(productSelectedCategories);
            await _productSelectedCategoryRepository.SaveChanges();

            //for remove all productColor
            _productColorRepository.DeletePermanentRange(await _productColorRepository
                .GetQuery().AsQueryable()
                .Where(s=>s.ProductId == product.Id).ToListAsync());
            //for create all productColor
            var productSelectedColor = new List<ProductColor>();

            foreach (var productColor in edit.ProductColor)
            {
                productSelectedColor.Add(new ProductColor
                {
                    ProductId = product.Id,
                    ColorName = productColor.ColorName,
                    ColorCode = productColor.ColorCode,
                    Price = productColor.Price
                });
            }

            await _productColorRepository.AddRangeEntity(productSelectedColor);
            await _productColorRepository.SaveChanges();
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