using System.ComponentModel.DataAnnotations;

namespace EModernHouse.DataLayer.DTOs.Site
{
    public class CreateSliderDTO
    {

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string MainHeader { get; set; }

        [Display(Name = "شناسه تصویر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Alt { get; set; }

        [Display(Name = "لینک")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Link { get; set; }

        [Display(Name = "وضعیت فعال / غیر فعال")]
        public bool IsActive { get; set; }
    }
}