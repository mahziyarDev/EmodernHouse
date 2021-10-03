using System.ComponentModel.DataAnnotations;

namespace EModernHouse.DataLayer.DTOs.Product
{
    public class EditProductCategoryDTO
    {
        public long CategoryId { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Title { get; set; }

        [Display(Name = "عنوان")]
        public string CategoryImage { get; set; }

        [Display(Name = "عنوان در URL")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string UrlName { get; set; }
    }
}