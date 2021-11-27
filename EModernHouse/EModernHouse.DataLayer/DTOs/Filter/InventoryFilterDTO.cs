using System.Collections.Generic;

namespace EModernHouse.DataLayer.DTOs.Filter
{
    public class InventoryFilterDTO : BasePaging
    {
        public List<Entities.Product.Product> Products { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}