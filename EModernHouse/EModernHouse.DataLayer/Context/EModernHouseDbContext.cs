using EModernHouse.DataLayer.Entities.Account;
using Microsoft.EntityFrameworkCore;

namespace EModernHouse.DataLayer.Context
{
    public class EModernHouseDbContext:DbContext 
    {
        #region DbSet

        public DbSet<User> Users { get; set; }

        #endregion

    }
}