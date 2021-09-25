using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Common;

namespace EModernHouse.DataLayer.Entities.Product
{
    public class ProductGallery : BaseEntity
    {
        #region properties

        public long ProductId { get; set; }


        [Display (Name = "ترتیب نمایش")]
        public int DisplayPriority { get; set; }

        [Display(Name = "توضیحات کوتاه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string ImageName { get; set; }

        [Display(Name = "نشان سئو")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Alt { get; set; }

        #endregion

        #region Relations

        public Product Product { get; set; }

        #endregion
    }
}