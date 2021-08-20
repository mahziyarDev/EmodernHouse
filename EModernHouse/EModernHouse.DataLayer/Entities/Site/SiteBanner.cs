using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Common;

namespace EModernHouse.DataLayer.Entities.Site
{
    public class SiteBanner : BaseEntity
    {
        #region Properties

        [Display(Name = "نام تصویر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
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

        #endregion
    }
}