using System.ComponentModel.DataAnnotations;

namespace EModernHouse.DataLayer.DTOs.Site
{
    public class CaptchaViewModel
    {
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Captcha { get; set; }
    }
}