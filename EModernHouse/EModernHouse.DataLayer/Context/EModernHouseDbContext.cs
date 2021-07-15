using System.Linq;
using EModernHouse.DataLayer.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace EModernHouse.DataLayer.Context
{
    public class EModernHouseDbContext:DbContext 
    {
        #region ConfigDataBase

        public EModernHouseDbContext(DbContextOptions<EModernHouseDbContext> options):base(options)
        {
            
        }

        #endregion

        #region DbSet

        public DbSet<User> Users { get; set; }

        #endregion

        #region on model Creating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(s => s.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Cascade;
            }

            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}