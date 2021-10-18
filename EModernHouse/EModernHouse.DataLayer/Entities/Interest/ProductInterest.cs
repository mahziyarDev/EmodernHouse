using EModernHouse.DataLayer.Entities.Account;
using EModernHouse.DataLayer.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace EModernHouse.DataLayer.Entities.Interest
{
    public class ProductInterest : BaseEntity
    {
        #region Properies

        public long ProductId { get; set; }
        public long UserId { get; set; }

        #endregion

        #region Relation

        public Product.Product Product { get; set; }
        public User User { get; set; }

        #endregion
    }
}