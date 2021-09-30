using System.Collections.Generic;
using EModernHouse.DataLayer.DTOs.Filter;
using EModernHouse.DataLayer.Entities.Product;

namespace EModernHouse.DataLayer.DTOs.Product
{
    public class CategoriesFilterDTO: BasePaging
    {
        public List<ProductCategory> ProductCategories { get; set; }
        public string Filter { get; set; }
    }
}