using System.Collections.Generic;
using EModernHouse.DataLayer.Entities.Discount;

namespace EModernHouse.DataLayer.DTOs.Filter
{
    public class DisCountFilterDTO : BasePaging
    {
        public List<ProductDisCount> ProductDisCounts { get; set; }
    }
}