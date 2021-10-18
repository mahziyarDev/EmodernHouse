using System.ComponentModel.DataAnnotations;
using EModernHouse.DataLayer.Entities.Account;
using EModernHouse.DataLayer.Entities.Common;

namespace EModernHouse.DataLayer.Entities.Wallet
{
    public class SellerWallet : BaseEntity
    {
        #region Properties

        public int Price { get; set; }
        public TransactionType TransactionType { get; set; }
        [Display(Name = "توضیحات")]
        [MaxLength(300,ErrorMessage = "{0} نمی تواند بیشتر از {1}کاراکتر باشد .")]
        public string Description { get; set; }
        #endregion
        
    }

    public enum TransactionType
    {
        [Display(Name = "واریز")]
        Deposit,
        [Display(Name = "برداشت")]
        Withdrawal
    }
}