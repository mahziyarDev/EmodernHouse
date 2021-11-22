using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Common;

namespace EModernHouse.DataLayer.Entities.Roles
{
    public class Roles : BaseEntity
    {
        #region properties
        [Display(Name = "عنوان دسترسی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Title { get; set; }

        #endregion
        #region Relational
        public ICollection<UserSelectedRole> UserSelectedRoles { get; set; }
        #endregion
    }
}