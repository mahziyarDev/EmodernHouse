using System.Collections.Generic;
using EModernHouse.DataLayer.DTOs.Filter;
using EModernHouse.DataLayer.Entities.Product;

namespace EModernHouse.DataLayer.DTOs.Product
{
    public class PopularProductsFilterDTO : BasePaging
    {
        public List<ProductForShowIndex> ProductForShowIndices { get; set; }
    }
}