using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Common;

namespace EModernHouse.DataLayer.Entities.Account
{
    public class UserAddress : BaseEntity   
    {
        #region Peroperties

        public long UserId { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(450,ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Address { get; set; }

        #endregion

        #region Relation

        public User User { get; set; }

        #endregion
    }
}