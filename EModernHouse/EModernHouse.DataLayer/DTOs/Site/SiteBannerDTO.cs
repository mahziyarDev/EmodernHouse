using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Site;

namespace EModernHouse.DataLayer.DTOs.Site
{
    public class SiteBannerDTO
    {
        [Display(Name = "نام تصویر")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string ImageName { get; set; }

        [Display(Name = "ادرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Url { get; set; }

        [Display(Name = "سایز(کلاس های نمایشی)")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string ColSize { get; set; }

        [Display(Name = "ویژگی alt")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Alt { get; set; }

        public BannerPlacement BannerPlacement { get; set; }
    }
}