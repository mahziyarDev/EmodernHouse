using System.Linq;
using EModernHouse.DataLayer.Entites.Contacts;
using EModernHouse.DataLayer.Entities.Account;
using EModernHouse.DataLayer.Entities.Contacts;
using EModernHouse.DataLayer.Entities.Discount;
using EModernHouse.DataLayer.Entities.Interest;
using EModernHouse.DataLayer.Entities.Product;
using EModernHouse.DataLayer.Entities.ProductOrder;
using EModernHouse.DataLayer.Entities.Site;
using EModernHouse.DataLayer.Entities.Wallet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
        public DbSet<SiteSetting> SiteSettings { get; set; }
        public DbSet<ContactUs> ContactUses { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SiteBanner> SiteBanners { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketMessage> TicketMessages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductSelectedCategory> ProductSelectedCategories { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductGallery> ProductGalleries { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductInterest> ProductInterests { get; set; }
        public DbSet<SellerWallet> SellerWallets { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public ProductDisCount ProductDisCount { get; set; }
        public ProductDiscountUse ProductDiscountUse { get; set; }
        #endregion

        #region on model Creating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(s => s.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

           


            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}