using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.DTOs.Site;

namespace EModernHouse.DataLayer.DTOs.Account
{
    public class EditUserProfileDTO 
    {
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string LastName { get; set; }

        [Display(Name = "تصویر اواتار")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Avatar { get; set; }
    }

    public enum EditUserProfileResult
    {
        NotFound,
        IsBlocked,
        IsNotActive,
        Success
    }
}