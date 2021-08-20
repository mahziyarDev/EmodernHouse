using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Common;

namespace EModernHouse.DataLayer.Entites.Contacts
{
    public class Slider : BaseEntity
    {
        #region Property

        [Display(Name = "نام تصویر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string ImageName { get; set; }

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

        #endregion
    }
}