using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Common;

namespace EModernHouse.DataLayer.Entities.Product
{
    public class ProductForShowIndex : BaseEntity
    {
        #region properties

        public long ProductId { get; set; }
        public Priority Priority { get; set; }

        #endregion

        #region Relational

        public Product Product { get; set; }

        #endregion
    }

    public enum Priority
    {
        [Display(Name = "پروفروش ترین ها")]
        Bestsellers,
        [Display(Name = "ارزان ترین ها")]
        Cheapest,
        [Display(Name = "محبوب ترین ها")]
        Favorites

    }

}