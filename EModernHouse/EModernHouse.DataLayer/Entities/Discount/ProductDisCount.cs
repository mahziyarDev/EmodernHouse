using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace EModernHouse.DataLayer.Entities.Discount
{
    public class ProductDisCount : BaseEntity
    {
        #region Properties

        public long ProductId { get; set; }

        [Range(0,100)]
        public int Percentage { get; set; }

        [Display(Name = "تاریخ اتمام تخفیف")]
        public DateTime ExpireDate { get; set; }

        #endregion

        #region Relation

        public Product.Product Product { get; set; }
        public ICollection<ProductDiscountUse> ProductDiscountUses { get; set; }
        #endregion
    }
}