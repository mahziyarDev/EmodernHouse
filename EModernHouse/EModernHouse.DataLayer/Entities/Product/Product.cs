using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Common;
using EModernHouse.DataLayer.Entities.Interest;
using EModernHouse.DataLayer.Entities.ProductOrder;

namespace EModernHouse.DataLayer.Entities.Product
{
    public class Product : BaseEntity
    {
        #region Properties

        [Display(Name = "نام محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(300, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Title { get; set; }

        [Display(Name = "تصویر محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(300, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string ImageName { get; set; }

        [Display(Name = "قیمت محصول")]
        public int Price { get; set; }

        [Display(Name = "توضیحات کوتاه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(450, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string ShortDescription { get; set; }

        [Display(Name = "توضیحات اصلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Description { get; set; }

        [Display(Name = "فعال / غیرفعال")]
        public bool IsActive { get; set; }

        [Display(Name = "لینک کوتاه محصول")]
        public string ShortLink { get; set; }

        #endregion

        #region Relations

        public ICollection<ProductSelectedCategory> ProductSelectedCategories { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
        public ICollection<ProductGallery> ProductGalleries { get; set; }
        public ICollection<ProductFeature> ProductFeatures { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<ProductInterest> ProductInterests { get; set; }
        #endregion
    }
}