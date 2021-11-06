using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Filter;
using EModernHouse.DataLayer.Entities.Product;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface IProductDiscountService : IAsyncDisposable
    {
        Task<DisCountFilterDTO> GetDiscount(int pageId,int take);
        Task<List<Product>> FilterProductByName(string productName);
    }
}