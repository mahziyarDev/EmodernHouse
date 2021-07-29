using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.DTOs.Site;

namespace EModernHouse.DataLayer.DTOs.Account
{
    public class ForgotPasswordDTO : CaptchaViewModel
    {
        [Display(Name = "تلفن همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Mobile { get; set; }
    }

    public enum ForgotPasswordResult
    {
        Success,
        NotFount,
        NotActivated
    }
}