using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Discount;
using EModernHouse.DataLayer.Entities.Product;
using EModernHouse.DataLayer.Entities.ProductComment;

namespace EModernHouse.DataLayer.DTOs.Product
{
    public class ProductDetailDTO
    {
        public long ProductId { get; set; }

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

        [Display(Name = "لینک کوتاه محصول")]
        public string ShortLink { get; set; }

        public ProductDisCount ProductDisCount { get; set; }
        public List<ProductColor> ProductColors { get; set; }
        public List<ProductGallery> ProductGalleries { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<ProductFeature> ProductFeatures { get; set; }
        public List<Entities.Product.Product> RelatedProducts { get; set; }
        public List<ProductComment> ProductComments { get; set; }

    }
}