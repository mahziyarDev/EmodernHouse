using System.Collections.Generic;

namespace EModernHouse.DataLayer.DTOs.Filter
{
    public class ProductUserFilterDTO : BasePaging  
    {
        public List<Entities.Product.Product> Products { get; set; }
        public string Category { get; set; }
        public int StartPrice  { get; set; }
        public int EndPrice { get; set; }
    }
}