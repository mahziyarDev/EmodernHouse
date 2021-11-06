using EModernHouse.DataLayer.Entities.Account;
using EModernHouse.DataLayer.Entities.Common;

namespace EModernHouse.DataLayer.Entities.Discount
{
    public class ProductDiscountUse : BaseEntity    
    {
        #region properties

        public long ProductDisCountId { get; set; }
        public long UserId { get; set; }
        #endregion

        #region Relation

        public User User { get; set; }
        public ProductDisCount ProductDisCount { get; set; }
        #endregion
    }
}