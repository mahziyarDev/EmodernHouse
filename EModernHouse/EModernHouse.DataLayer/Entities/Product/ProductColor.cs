using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Common;
using EModernHouse.DataLayer.Entities.ProductOrder;

namespace EModernHouse.DataLayer.Entities.Product
{
    public class ProductColor : BaseEntity
    {
        #region Property

        public long ProductId { get; set; }

        [Display(Name = "رنگ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string ColorName { get; set; }
        public string ColorCode { get; set; }
        public int Price { get; set; }
        #endregion

        #region Relation

        public Product Product { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        #endregion
    }
}