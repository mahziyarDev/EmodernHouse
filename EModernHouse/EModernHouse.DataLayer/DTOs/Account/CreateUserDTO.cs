using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Roles;

namespace EModernHouse.DataLayer.DTOs.Account
{
    public class CreateUserDTO
    {
        [Display(Name = "ایمیل")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "ایمیل فعال / غیر فعال")]
        public bool IsEmailActive { get; set; }

        [Display(Name = "تلفن همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Mobile { get; set; }

        [Display(Name = "موبایل فعال / غیر فعال")]
        public bool IsMobileActive { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Password { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string LastName { get; set; }

        [Display(Name = "سطح دسترسی های کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public List<long> Roles { get; set; }
    }


}