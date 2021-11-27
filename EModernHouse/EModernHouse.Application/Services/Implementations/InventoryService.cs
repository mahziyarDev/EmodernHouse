using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Filter;
using EModernHouse.DataLayer.Entities.Product;
using EModernHouse.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace EModernHouse.Application.Services.Implementations
{
    public class InventoryService : IInventoryService
    {
        #region CTOR

        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<ProductColor> _productColorRepository;

        public InventoryService(IGenericRepository<Product> productRepository, IGenericRepository<ProductColor> productColorRepository)
        {
            _productRepository = productRepository;
            _productColorRepository = productColorRepository;
        }

        #endregion

        //public async Task<List<Product>> ProductFilter(InventoryFilterDTO inventory)
        //{
        //    IQueryable<Product> query = _productRepository.GetQuery().AsQueryable()
        //        .Include(s => s.ProductColors);

        //    if (!string.IsNullOrEmpty(inventory.ProductName))
        //    {
        //        query =  query.Where(s => EF.Functions.Like(s.Title, $"%{inventory.ProductName}%"));
        //    }

        //    if (inventory.Price <= 0)
        //    {
        //        query = query.Where(s => s.Price <= inventory.Price);
        //    }

        //    var skip = (pageId - 1) * take;
        //    var model = new ProductUserFilterDTO
        //    {
        //        Products = await result.Skip(skip).Take(take).ToListAsync(),
        //        StartPrice = startPrice,
        //        EndPage = endPrice,

        //    };
        //    model.GeneratePaging(result, pageId, take);
        //    return model;
        //}

        #region Dispose
        public async ValueTask DisposeAsync()
        {
            await _productRepository.DisposeAsync();
            await _productColorRepository.DisposeAsync();
        }
        #endregion

    }
}