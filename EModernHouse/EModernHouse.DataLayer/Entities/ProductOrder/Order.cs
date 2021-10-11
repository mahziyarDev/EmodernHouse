using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Account;
using EModernHouse.DataLayer.Entities.Common;

namespace EModernHouse.DataLayer.Entities.ProductOrder
{
    public class Order : BaseEntity
    {
        #region Peroperties

        public long UserId { get; set; }

        public DateTime? PaymentDate { get; set; }

        public bool IsPaid { get; set; }
              
        [Display(Name = "کد پیگیری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(300)]
        public string TracingCode { get; set; }

        [Display(Name = "کد پیگیری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Description { get; set; }
        #endregion

        #region Relation

        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }


        #endregion
    }
}