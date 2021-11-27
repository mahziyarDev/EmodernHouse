using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Filter;
using EModernHouse.DataLayer.Entities.Product;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface IInventoryService : IAsyncDisposable
    {
        //Task<List<Product>> ProductFilter(InventoryFilterDTO inventory);
    }
}