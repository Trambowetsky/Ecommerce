using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<AdminModel> AdminModels { get; set; }
        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<ProductModel> ProductModels { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<MainInfo> MainInfos { get; set; }
        public DbSet<AdministrationLevel> AdministrationLevels { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            if (Database.EnsureCreated())
            {
                InitializeDbDefaultValues();
            }
        }
        protected void InitializeDbDefaultValues()
        {
            InitDefaultCategory();
            InitShopData();
            InitDefaultAdminLevels();
            InitDefaultAdminUser();
            InitDefaultProduct();
        }

        protected void InitDefaultAdminLevels()
        {
            AdministrationLevels.AddRange(
                new AdministrationLevel() { LevelName = "Moderator" },
                new AdministrationLevel() { LevelName = "Admin" },
                new AdministrationLevel() { LevelName = "Owner" }
            );
            this.SaveChangesAsync();
        }
        protected void InitShopData() 
        {
            MainInfos.Add(new MainInfo() {
                ShopName = "Default Ecommerce",
                ShopCurrency = "₴"
            });
            this.SaveChangesAsync();
        }
        protected void InitDefaultAdminUser()
        {
            AdminModels.Add(new AdminModel()
            {
                Id = Guid.NewGuid(),
                Login = "admin",
                Password = "admin",
                AdminLevel = AdministrationLevels.FirstOrDefault(l => l.LevelName == "Owner")
            });
            this.SaveChangesAsync();
        }
        protected void InitDefaultProduct() 
        {
            ProductModels.Add(new ProductModel() { 
                Name = "Default product",
                Price = 500,
                Category = ProductCategories.FirstOrDefault(c => c.IsMain == true),
                IsNew = true
            });
            this.SaveChangesAsync();
        }
        protected void InitDefaultCategory()
        {
            ProductCategories.Add(new ProductCategory() { Name = "Default category", IsMain = true });
            this.SaveChangesAsync();
        }
    }
}
