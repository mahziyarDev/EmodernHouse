using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Common;

namespace EModernHouse.DataLayer.Entities.Site
{
    public class SiteSetting:BaseEntity     
    {
        #region Properties

        [Display(Name = "تلفن ثابت")]
        [MaxLength(25,ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Phone { get; set; }

        [Display(Name = "تلفن همراه")]
        [MaxLength(25, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Mobile { get; set; }

        [Display(Name = "ایمیل")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Email { get; set; }

        [Display(Name = "لوگو")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Logo { get; set; }

        [Display(Name = "متن کپی رایت")]
        [MaxLength(350, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string CopyRight { get; set; }

        [Display(Name = "وضعیت فعال / غیر فعال")]
        public bool IsDefault { get; set; }
        #endregion
    }
}