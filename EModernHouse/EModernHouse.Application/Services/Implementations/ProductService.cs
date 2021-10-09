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
using EModernHouse.DataLayer.DTOs.Filter;


namespace EModernHouse.Application.Services.Implementations
{
    public class ProductService : IProductService
    {
        #region Ctor

        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<ProductCategory> _productCategoryRepository;
        private readonly IGenericRepository<ProductSelectedCategory> _productSelectedCategoryRepository;
        private readonly IGenericRepository<ProductColor> _productColorRepository;
        private readonly IGenericRepository<ProductGallery> _productGalleryRepository;
        private readonly IGenericRepository<ProductFeature> _productFeatureRepository;

        public ProductService(IGenericRepository<Product> productRepository, IGenericRepository<ProductCategory> productCategoryRepository, IGenericRepository<ProductSelectedCategory> productSelectedCategoryRepository, IGenericRepository<ProductColor> productColorRepository, IGenericRepository<ProductGallery> productGalleryRepository, IGenericRepository<ProductFeature> productFeatureRepository)
        {
            _productRepository = productRepository;
            _productCategoryRepository = productCategoryRepository;
            _productSelectedCategoryRepository = productSelectedCategoryRepository;
            _productColorRepository = productColorRepository;
            _productGalleryRepository = productGalleryRepository;
            _productFeatureRepository = productFeatureRepository;
        }
        #endregion

        #region filterProduc

        public async Task<Tuple<List<Product>, int>> GetProductForFilter(int pageId, int take, string productName)
        {
            IQueryable<Product> products = _productRepository.GetQuery().AsQueryable()
                .Where(s => !s.IsDelete);

            #region filter

            if (!string.IsNullOrEmpty(productName))
            {
                products = products.Where(s => s.Title.Contains(productName));
            }

            

            #endregion

            int skip = (pageId - 1) * take;
            int pageCount = (products.Count() % take == 0 ? products.Count() / take : (products.Count() / take) + 1);
            List<Product> result = await products.Skip(skip).Take(take).ToListAsync();
            return Tuple.Create(result, pageCount);
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

        #region ProductGallery

        public async Task<List<ProductGallery>> GetAllGalleryForProduct(long productID)
        {
            return await _productGalleryRepository.GetQuery().AsQueryable()
                .Where(s => !s.IsDelete && s.ProductId == productID).ToListAsync();
            
        }
        public async Task<bool> AddImageProductForGallery(CreateProductGalleryDTO gallery)
        {
            var productGallery = new ProductGallery
            {
                ProductId = gallery.ProductId,
                DisplayPriority = gallery.DisplayPriority,
                ImageName = gallery.ImageName,
                Alt = gallery.Alt
                
            };
            await _productGalleryRepository.AddEntity(productGallery);
            await _productGalleryRepository.SaveChanges();
            return true;
        }

        public async Task<bool> EditProductGallery(long galleryId, int displayPriority, string alt, string newImage)
        {
            var gallery = await _productGalleryRepository.GetEntityById(galleryId);
            gallery.ImageName = newImage;
            gallery.Alt = alt;
            gallery.DisplayPriority = displayPriority;

            _productGalleryRepository.EditEntity(gallery);
            await _productGalleryRepository.SaveChanges();
            return true;
        }

        public async Task<long> DeleteProductGalleryById(long galleryId)
        {
            var productGallery = await _productGalleryRepository.GetEntityById(galleryId);
            var productId = productGallery.ProductId;
            if (File.Exists(PathExtensions.ProductGalleryImageThumbServer+productGallery.ImageName)&&File.Exists(PathExtensions.ProductGalleryImageOriginServer+productGallery.ImageName))
            {
               File.Delete(PathExtensions.ProductGalleryImageOriginServer+productGallery.ImageName);
               File.Delete(PathExtensions.ProductGalleryImageThumbServer+productGallery.ImageName);
            }
            _productGalleryRepository.Delete(productGallery);
            await _productGalleryRepository.SaveChanges();
            return productId;
        }
        #endregion

        #region ProductColor

        public async Task<bool> CreateColorProduct(CreateProductColorDTO create)
        {
            var colorProduct = new ProductColor
            {
                ProductId = create.ProductId,
                ColorCode = create.ColorCode,
                ColorName = create.ColorName,
                Price = create.Price
            };
            await _productColorRepository.AddEntity(colorProduct);
            await _productColorRepository.SaveChanges();
            return true;
        }

        public async Task<List<ProductColor>> GetProductColorByproductId(long productId)
        {
            var productColor = await _productColorRepository.GetQuery().AsQueryable()
                .Where(s => s.ProductId == productId).ToListAsync();
            return productColor;

        }

        public async Task<long> DeleteProductColorById(long colorId)
        {
            var color = await _productColorRepository.GetEntityById(colorId);
            long id = color.ProductId;
            _productColorRepository.Delete(color);
            await _productColorRepository.SaveChanges();
            return id;
        }

        public async Task<bool> EditProductColor(long colorId, string colorName, string colorCode, int price)
        {
            var color =await _productColorRepository.GetEntityById(colorId);
            color.ColorName = colorName;
            color.ColorCode = colorCode;
            color.Price = price;
            _productColorRepository.EditEntity(color);
            await _productColorRepository.SaveChanges();
            return true;
        }
        #endregion

        #region categories

        public CategoriesFilterDTO GetCategoriesForList(int pageId, int take, string filter)
        {
            IQueryable<ProductCategory> categories =_productCategoryRepository.GetQuery().AsQueryable();

            if (!string.IsNullOrEmpty(filter))
            {
                categories = categories.Where(s => s.Title.Contains(filter));
            }

            var skip = (pageId - 1) * take;
            var model = new CategoriesFilterDTO
            {
                Filter = filter,
                ProductCategories = categories.OrderByDescending(s=>s.Id).Skip(skip).Take(take).ToList()
            };

            model.GeneratePaging(categories,pageId,take);
            return model;
        }

        public async Task<List<ProductCategory>> GetAllProductCategoriesForList()
        {
           return  await _productCategoryRepository.GetQuery().AsQueryable().Where(s => !s.IsDelete).ToListAsync();
        }

        public async Task<bool> DeleteCategories(long id)
        {
            var category = await _productCategoryRepository.GetEntityById(id);
            
            if (category == null)
            {
                return false;
            }
            if (!string.IsNullOrEmpty(category.CategoryImage))
            {
                if (File.Exists(PathExtensions.CategoryImageImageThumbServer + category.CategoryImage) && File.Exists(PathExtensions.CategoryImageImageOriginServer + category.CategoryImage))
                {
                    File.Delete(PathExtensions.CategoryImageImageOriginServer + category.CategoryImage);
                    File.Delete(PathExtensions.CategoryImageImageThumbServer + category.CategoryImage);
                }

            }
            _productCategoryRepository.Delete(category);
            await _productCategoryRepository.SaveChanges();
            return true;
        }

        public async Task<bool> CreateMainCategory(string name, string imageName)
        {
            var category = new ProductCategory
            {
                ParentId = null,
                UrlName = null,
                Title = name,
                CategoryImage = imageName,
                IsActive = true
                
            };
            await _productCategoryRepository.AddEntity(category);
            await _productCategoryRepository.SaveChanges();
            return true;
        }

        public async Task<EditProductCategoryDTO> GetMainCategoryForEdit(long categoryId)
        {
            var category = await _productCategoryRepository.GetEntityById(categoryId);
            return new EditProductCategoryDTO
            {
                CategoryId = category.Id,
                CategoryImage = category.CategoryImage,
                Title = category.Title,
                UrlName = category.UrlName,

            };
        }

        public async Task<bool> SetMainCategoryForEdit( EditProductCategoryDTO edit)
        {
            var category = await _productCategoryRepository.GetEntityById(edit.CategoryId);
            if (category == null)
            {
                return false;
            }

            category.Title = edit.Title;
            category.UrlName = edit.UrlName;
            category.CategoryImage = edit.CategoryImage;
            _productCategoryRepository.EditEntity(category);
            await _productCategoryRepository.SaveChanges();
            return true;
        }

        public async Task<bool> CreateSubGroups(long groupId, string groupName)
        {
            var subCategory = new ProductCategory
            {
                UrlName = null,
                Title = groupName,
                ParentId = groupId,
                CategoryImage = null
            };
            await _productCategoryRepository.AddEntity(subCategory);
            await _productCategoryRepository.SaveChanges();
            return true;
        }
        #endregion

        #region ProductForClient

        public async Task<ProductUserFilterDTO> GetProductsForUsers(int pageId, int take, int startPrice, int endPrice, long? category)
        {
            var result = _productRepository.GetQuery()
                .Include(s=>s.ProductSelectedCategories)
                .ThenInclude(s=>s.ProductCategory)
                .AsQueryable();
            if (startPrice > 0)
            {
                result = result.Where(p => p.Price >= startPrice);
            }
            if (endPrice > 0)
            {
                result = result.Where(p => p.Price <= endPrice);
            }

            if ( category != null)
            {
                result = result.Where(s => s.ProductSelectedCategories.Any(s => s.ProductCategory.Id == category));
            }
            var skip = (pageId - 1) * take;
            var model = new ProductUserFilterDTO
            {
                Products = await result.Skip(skip).Take(take).ToListAsync(),
                StartPrice = startPrice,
                EndPage = endPrice,
               
            };
            model.GeneratePaging(result,pageId,take);
            return model;
        }

        public async Task<ProductDetailDTO> GetProductDetail(long productId)
        {
            var product = await _productRepository
                .GetQuery().AsQueryable()
                .Include(s => s.ProductSelectedCategories)
                .ThenInclude(s => s.ProductCategory)
                .Include(s => s.ProductGalleries)
                .Include(s => s.ProductColors)
                .Include(s=>s.ProductFeatures)
                .SingleOrDefaultAsync(s => s.Id == productId);
            if (product == null) return null;
            return new ProductDetailDTO
            {
                Title = product.Title,
                Price = product.Price,
                ShortDescription = product.ShortDescription,
                Description = product.Description,
                ImageName = product.ImageName,
                ProductCategories = product.ProductSelectedCategories.Select(s => s.ProductCategory).ToList(),
                ShortLink = product.ShortLink,
                ProductColors = product.ProductColors.ToList(),
                ProductGalleries = product.ProductGalleries.ToList(),
                ProductFeatures = product.ProductFeatures.ToList()
            };
        }

        #endregion

        #region Product Feature

        public async Task CreateProductFeatures(CreateProductFeatureDTO feature)
        {
            var newProductFeature = new ProductFeature
            {
                ProductId = feature.ProductId,
                FeatureTitle = feature.FeatureTitle,
                FeatureValue = feature.FeatureValue
            };

            await _productFeatureRepository.AddEntity(newProductFeature);
            await _productFeatureRepository.SaveChanges();

        }

        public async Task RemoveProductFeature(long productFeatureId)
        {
            var productFeature = await _productFeatureRepository.GetEntityById(productFeatureId);
            _productFeatureRepository.Delete(productFeature);
            await _productFeatureRepository.SaveChanges();
        }

        public async Task<List<ProductFeature>> GetAllProductFeaturesById(long productId)
        {
            return await _productFeatureRepository.GetQuery().AsQueryable()
                .Where(s => s.ProductId == productId)
                .ToListAsync();
        }
        #endregion

        #region Disposiable

        public async ValueTask DisposeAsync()
        {
            await _productRepository.DisposeAsync();
            await _productColorRepository.DisposeAsync();
            await _productCategoryRepository.DisposeAsync();
            await _productSelectedCategoryRepository.DisposeAsync();
            await _productGalleryRepository.DisposeAsync();
            await _productFeatureRepository.DisposeAsync();
        }

        #endregion
    }
}