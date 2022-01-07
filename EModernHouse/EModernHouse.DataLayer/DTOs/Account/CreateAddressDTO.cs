using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Account;

namespace EModernHouse.DataLayer.DTOs.Account
{
    public class CreateAddressDTO
    {
        public long UserId { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public Cities Cities { get; set; }
        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(450, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Address { get; set; }
    }
}