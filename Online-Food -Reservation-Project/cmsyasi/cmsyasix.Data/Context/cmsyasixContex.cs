using cmsyasix.Data.Entities.Food;
using cmsyasix.Data.Entities.Order;
using cmsyasix.Data.Entities.Permission;
using cmsyasix.Data.Entities.User;
using cmsyasix.Data.Entities.Wallet;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cmsyasix.Data.Context
{
    public class cmsyasixContex: DbContext
    {
        public cmsyasixContex(DbContextOptions<cmsyasixContex> options) : base(options)
        {

        }

        #region User

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserDiscount> UserDiscounts { get; set; }

        #endregion
        #region Wallet
        public DbSet<WalletType> WalletTypes { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        #endregion
        #region Permission
        public DbSet<Permission> Permission { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }
        #endregion

        #region Food
        public DbSet<FoodGroup> FoodGroups { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodComment> FoodComments { get; set; }
        #endregion
        #region Order
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail>  OrderDetails { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<SendProduct> SendProducts { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;


            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDelete);
            modelBuilder.Entity<Role>()
                .HasQueryFilter(r => !r.IsDelete);
            modelBuilder.Entity<FoodGroup>()
                .HasQueryFilter(f => !f.IsDelete);
            base.OnModelCreating(modelBuilder);
        }
    }
}
