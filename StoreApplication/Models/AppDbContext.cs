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
        public DbSet<OriginCountry> Countries { get; set; }
        public DbSet<Localization> Localizations{ get; set; }
        public DbSet<Sex> Genders { get; set; }

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
            InitDefaultSexOptions();
            InitDefaultLocalizations();
            InitDefaultCountries();
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
            this.SaveChanges();
        }
        protected void InitShopData() 
        {
            MainInfos.Add(new MainInfo() {
                ShopName = "Default Ecommerce",
                ShopCurrency = "₴"
            });
            this.SaveChanges();
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
            this.SaveChanges();
        }
        protected void InitDefaultProduct() 
        {
            ProductModels.Add(new ProductModel() { 
                Name = "Default product",
                Price = 500,
                Category = ProductCategories.FirstOrDefault(c => c.IsMain == true),
                IsNew = true
            });
            this.SaveChanges();
        }
        protected void InitDefaultCountries() {
            Countries.AddRange(
                new OriginCountry() 
                { 
                    CountryName = "US",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "en")
                },
                new OriginCountry()
                {
                    CountryName = "UK",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "en")
                }, new OriginCountry()
                {
                    CountryName = "China",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "en")
                }, new OriginCountry()
                {
                    CountryName = "Taiwan",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "en")
                }, new OriginCountry()
                {
                    CountryName = "South Korea",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "en")
                }, new OriginCountry()
                {
                    CountryName = "Germany",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "en")
                }, new OriginCountry()
                {
                    CountryName = "France",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "en")
                }, new OriginCountry()
                {
                    CountryName = "Ukraine",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "en")
                }, new OriginCountry()
                {
                    CountryName = "США",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "ua")
                },
                new OriginCountry()
                {
                    CountryName = "Велика Британія",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "ua")
                }, new OriginCountry()
                {
                    CountryName = "Китай",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "ua")
                }, new OriginCountry()
                {
                    CountryName = "Тайвань",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "ua")
                }, new OriginCountry()
                {
                    CountryName = "Південна Корея",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "ua")
                }, new OriginCountry()
                {
                    CountryName = "Німеччина",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "ua")
                }, new OriginCountry()
                {
                    CountryName = "Франція",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "ua")
                }, new OriginCountry()
                {
                    CountryName = "Україна",
                    NameLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "ua")
                }
                );
            this.SaveChanges();
        }
        protected void InitDefaultLocalizations() {
            Localizations.AddRange(new Localization() 
            {
                Id = Guid.NewGuid(),
                LocalizationName = "en"
            },
            new Localization()
            {
                Id = Guid.NewGuid(),
                LocalizationName = "ua"
            });
        }
        protected void InitDefaultSexOptions() {
            Genders.AddRange(
                new Sex()
                {
                    Id = Guid.NewGuid(),
                    Name = "F",
                    SexLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "en")
                },
                new Sex()
                {
                    Id = Guid.NewGuid(),
                    Name = "M",
                    SexLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "en")
                },
                new Sex()
                {
                    Id = Guid.NewGuid(),
                    Name = "чол.",
                    SexLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "ua")
                },
                new Sex()
                {
                    Id = Guid.NewGuid(),
                    Name = "жін.",
                    SexLocalization = Localizations.FirstOrDefault(l => l.LocalizationName == "ua")
                }
            );
            this.SaveChanges();
        }
        protected void InitDefaultCategory()
        {
            ProductCategories.Add(new ProductCategory() { Name = "Default category", IsMain = true });
            this.SaveChanges();
        }
    }
}
