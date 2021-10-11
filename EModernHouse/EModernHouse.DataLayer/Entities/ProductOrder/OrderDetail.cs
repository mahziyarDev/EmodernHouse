using EModernHouse.DataLayer.Entities.Common;
using EModernHouse.DataLayer.Entities.Product;

namespace EModernHouse.DataLayer.Entities.ProductOrder
{
    public class OrderDetail : BaseEntity
    {

        #region Peroperties

        public long OrderId { get; set; }

        public long ProductId { get; set; }

        public int Count { get; set; }

        public long? ProductColorId { get; set; }

        public int ProductPrice { get; set; }

        public int ProductColorPrice { get; set; }
        #endregion

        #region Relation

        public Order Order { get; set; }
        public Product.Product Product { get; set; }
        public ProductColor ProductColor { get; set; }
        #endregion
    }
}