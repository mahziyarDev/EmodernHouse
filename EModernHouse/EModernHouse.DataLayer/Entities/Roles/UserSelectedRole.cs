using EModernHouse.DataLayer.Entities.Account;
using EModernHouse.DataLayer.Entities.Common;

namespace EModernHouse.DataLayer.Entities.Roles
{
    public class UserSelectedRole : BaseEntity
    {
        #region Properties
        public long UserId { get; set; }
        public long RolesId { get; set; }
        #endregion

        #region Relational
        public User User { get; set; }
        public Roles Roles { get; set; }
        #endregion

    }
}