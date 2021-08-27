using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.DTOs.Site;

namespace EModernHouse.DataLayer.DTOs.Account
{
    public class ChangePasswordDTO
    {
        [Display(Name = "رمز عبور قبلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string CurrentPassword { get; set; }

        [Display(Name = "رمز عبور جدید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string NewPassword { get; set; }

        [Display(Name = "تکرار رمز عبور جدبد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        [Compare("NewPassword", ErrorMessage = "کلمه های عبور باهم مغایرت دارند")]
        public string ConfirmPassword { get; set; }
    }

    public enum ChangePasswordResult
    {
        Success,
        Repetition,
        Error

    }
}