using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Filter;
using EModernHouse.DataLayer.DTOs.Product;
using EModernHouse.DataLayer.Entities.Product;
using EModernHouse.DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace EModernHouse.Application.Services.Implementations
{
    public class InventoryService : IInventoryService
    {
        #region CTOR

        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<ProductColor> _productColorRepository;
        private readonly IGenericRepository<ProductForShowIndex> _productForShowIndexRepository;

        public InventoryService(IGenericRepository<Product> productRepository, IGenericRepository<ProductColor> productColorRepository, IGenericRepository<ProductForShowIndex> productForShowIndexRepository)
        {
            _productRepository = productRepository;
            _productColorRepository = productColorRepository;
            _productForShowIndexRepository = productForShowIndexRepository;
        }

        #endregion

        #region ForInventory

        public async Task<InventoryFilterDTO> GetProducyForInventory(int pageId, int take, string productName)
        {
            var query = _productRepository.GetQuery()
                .Include(s => s.ProductColors).AsQueryable();

            if (!string.IsNullOrEmpty(productName))
            {
                query = query.Where(s => s.Title.Contains(productName));
            }

            var skip = (pageId - 1) * take;
            var model = new InventoryFilterDTO
            {
                Products = await query.Skip(skip).Take(take).ToListAsync(),
                ProductName = productName
            };
            model.GeneratePaging(query, pageId, take);
            return model;
        }

        public async Task<List<ProductColor>> ProductColors(long productId)
        {
            var colors = await _productColorRepository.GetQuery().AsQueryable()
                .Where(s => s.ProductId == productId && !s.IsDelete)
                .ToListAsync();
            return colors;
        }

        public async Task<bool> InsertNumberCount(long colorId, int count)
        {
            var color = await _productColorRepository.GetEntityById(colorId);
            color.Count = count;
            _productColorRepository.EditEntity(color);
            await _productColorRepository.SaveChanges();
            return true;
        }

        #endregion

        #region ForProductShowIndex

        public async Task<PopularProductsFilterDTO> GetPopularProducts(int pageId, int take)
        {
            var query = _productForShowIndexRepository.GetQuery().AsQueryable()
                .Include(s=>s.Product)
                .Where(s => !s.IsDelete);
           

            var skip = (pageId - 1) * take;
            var model = new PopularProductsFilterDTO
            {
                ProductForShowIndices = await query.Skip(skip).Take(take).ToListAsync(),
               
            };
            model.GeneratePaging(query, pageId, take);
            return model;
        }

        public async Task<bool> DeletePopularProduct(long popularId)
        {
            var popular = await _productForShowIndexRepository.GetEntityById(popularId);
            if (popular != null) 
            {
                _productForShowIndexRepository.Delete(popular);
                await _productForShowIndexRepository.SaveChanges();
                return true;
            }

            return false;
        }
        #endregion

        #region Dispose
        public async ValueTask DisposeAsync()
        {
            await _productRepository.DisposeAsync();
            await _productColorRepository.DisposeAsync();
        }
        #endregion

    }
}