using System.ComponentModel.DataAnnotations;

namespace EModernHouse.DataLayer.DTOs.Comment
{
    public class CreateCommentDTO
    {
        public long? ParentId { get; set; }
        public long ProductId { get; set; }
        [Display(Name = "عنوان کامنت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string TitleComment { get; set; }

        [Display(Name = "ایمیل کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string EmailUser { get; set; }

        [Display(Name = "متن کامنت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string TextComment { get; set; }
    }
}