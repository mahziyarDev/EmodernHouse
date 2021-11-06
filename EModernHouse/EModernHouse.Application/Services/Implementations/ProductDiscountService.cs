using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Filter;
using EModernHouse.DataLayer.Entities.Discount;
using EModernHouse.DataLayer.Entities.Product;
using EModernHouse.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace EModernHouse.Application.Services.Implementations
{
    public class ProductDiscountService : IProductDiscountService
    {
        #region Ctor

        private readonly IGenericRepository<ProductDisCount> _productDisCountRepository;
        private readonly IGenericRepository<ProductDiscountUse> _productDiscountUseRepository;
        private readonly IGenericRepository<Product> _productRepository;

        public ProductDiscountService(IGenericRepository<ProductDisCount> productDisCountRepository, IGenericRepository<ProductDiscountUse> productDiscountUseRepository, IGenericRepository<Product> productRepository)
        {
            _productDisCountRepository = productDisCountRepository;
            _productDiscountUseRepository = productDiscountUseRepository;
            _productRepository = productRepository;
        }
        #endregion

        public async Task<DisCountFilterDTO> GetDiscount(int pageId, int take)
        {
            var query = _productDisCountRepository.GetQuery().AsQueryable()
                .Where(s => !s.IsDelete)
                .Include(s=>s.Product);
            var skip = (pageId - 1) * take;
            var model = new DisCountFilterDTO
            {
                ProductDisCounts = await query.Skip(skip).Take(take).ToListAsync(),
            };
            model.GeneratePaging(query, pageId, take);
            return model;
        }

        public async Task<List<Product>> FilterProductByName(string productName)
        {
            var products = await _productRepository.GetQuery().AsQueryable()
                .Where(s => EF.Functions.Like(s.Title , $"%{productName}%"))
                .ToListAsync();
            return products;
        }
        #region Dispose

        public async ValueTask DisposeAsync()
        {
            await _productDisCountRepository.DisposeAsync();
            await _productDiscountUseRepository.DisposeAsync();
        }

        #endregion

    }
}