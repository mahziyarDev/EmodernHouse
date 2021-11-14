using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Account;
using EModernHouse.DataLayer.Entities.Common;

namespace EModernHouse.DataLayer.Entities.ProductComment
{
    public class ProductComment : BaseEntity
    {
        #region Properties

        public long? ParentId { get; set; }
        public long ProductId { get; set; }
        public long UserId { get; set; }
        [Display(Name = "عنوان کامنت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string TitleComment { get; set; }

        [Display(Name = "ایمیل کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string EmailUser { get; set; }

        [Display(Name = "متن کامنت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string TextComment { get; set; }

        [Display(Name = "وضعیت کامنت")]
        public ProductCommentState ProductCommentState { get; set; }


        #endregion

        #region Relation

        public ProductComment Parent { get; set; }
        public Product.Product Product { get; set; }
        public User User { get; set; }

        #endregion
    }

    public enum ProductCommentState
    {
        [Display(Name = "در حال بررسی")]
        UnderProgress,
        [Display(Name = "رد شده")]
        Rejected,
        [Display(Name = "تایید شده")]
        Accepted
    }
}