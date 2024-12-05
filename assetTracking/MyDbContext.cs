using AssetNameSpace;
using OfficeNameSpace;
using Microsoft.EntityFrameworkCore;


namespace MyDbContextNamespace
{
    internal class MyDbContext : DbContext
    {
        string ConnectionString = "Server=localhost,1433;Database=assetTracking;User Id=sa;Password=Dayton1982*;Encrypt=true;TrustServerCertificate=true;";
        // string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=many2many;User Id=sa;Password=Dayton1982*;Encrypt=true;TrustServerCertificate=true;";
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Office> Offices { get; set; }

        // Configure the DbContext in Entity Framework Core.
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            OptionsBuilder.UseSqlServer(ConnectionString);
        }

        // Data Seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define the relationship between Office and Asset
            modelBuilder.Entity<Asset>()
                .HasOne(a => a.Office)
                .WithMany(o => o.Assets)
                .HasForeignKey(a => a.OfficeId);

            modelBuilder.Entity<Office>().HasData(
                new Office { Id = 1, Name = "USA", LocalCurrency = "usd"},
                new Office { Id = 2, Name = "Sweden", LocalCurrency = "sek"},
                new Office { Id = 3, Name = "Germany", LocalCurrency = "eur"}
            );

            modelBuilder.Entity<Asset>().HasData(
                new Asset { Id = 1, Type = "Smartphone", Brand = "Motorola", Model = "X3", Price = 200, PurchaseDate = new DateTime(2022, 4, 5).Date, OfficeId = 1 },
                new Asset { Id = 2, Type = "Smartphone", Brand = "Motorola", Model = "X3", Price = 400, PurchaseDate = new DateTime(2022, 5, 5).Date, OfficeId = 1 },
                new Asset { Id = 3, Type = "Smartphone", Brand = "Motorola", Model = "X2", Price = 400, PurchaseDate = new DateTime(2022, 10, 5).Date, OfficeId = 1 },
                new Asset { Id = 4, Type = "Smartphone", Brand = "Samsung", Model = "Galaxy 10", Price = 4500, PurchaseDate = new DateTime(2022, 6, 5).Date, OfficeId = 2 },
                new Asset { Id = 5, Type = "Smartphone", Brand = "Samsung", Model = "Galaxy 10", Price = 4500, PurchaseDate = new DateTime(2022, 7, 5).Date, OfficeId = 2 },
                new Asset { Id = 6, Type = "Smartphone", Brand = "Sony", Model = "XPeria 7", Price = 3000, PurchaseDate = new DateTime(2022, 4, 5).Date, OfficeId = 2 },
                new Asset { Id = 7, Type = "Smartphone", Brand = "Sony", Model = "XPeria 7", Price = 3000, PurchaseDate = new DateTime(2022, 5, 5).Date, OfficeId = 2 },
                new Asset { Id = 8, Type = "Smartphone", Brand = "Siemens", Model = "Brick", Price = 220, PurchaseDate = new DateTime(2022, 12, 5).Date, OfficeId = 3 },
                new Asset { Id = 9, Type = "Computer", Brand = "Dell", Model = "Desktop 900", Price = 100, PurchaseDate = new DateTime(2021, 10, 5).Date, OfficeId = 1 },
                new Asset { Id = 10, Type = "Computer", Brand = "Dell", Model = "Desktop 900", Price = 100, PurchaseDate = new DateTime(2021, 11, 5).Date, OfficeId = 1 },
                new Asset { Id = 11, Type = "Computer", Brand = "Lenovo", Model = "X100", Price = 300, PurchaseDate = new DateTime(2022, 1, 5).Date, OfficeId = 1 },
                new Asset { Id = 12, Type = "Computer", Brand = "Lenovo", Model = "X200", Price = 300, PurchaseDate = new DateTime(2022, 4, 5).Date, OfficeId = 1 },
                new Asset { Id = 13, Type = "Computer", Brand = "Lenovo", Model = "X300", Price = 500, PurchaseDate = new DateTime(2022, 9, 5).Date, OfficeId = 1 },
                new Asset { Id = 14, Type = "Computer", Brand = "Dell", Model = "Optiplex 100", Price = 1500, PurchaseDate = new DateTime(2022, 7, 5).Date, OfficeId = 2 },
                new Asset { Id = 15, Type = "Computer", Brand = "Dell", Model = "Optiplex 200", Price = 1400, PurchaseDate = new DateTime(2022, 8, 5).Date, OfficeId = 2 },
                new Asset { Id = 16, Type = "Computer", Brand = "Dell", Model = "Optiplex 300", Price = 1300, PurchaseDate = new DateTime(2022, 9, 5).Date, OfficeId = 2 },
                new Asset { Id = 17, Type = "Computer", Brand = "Asus", Model = "ROG 600", Price = 1600, PurchaseDate = new DateTime(2023, 2, 5).Date, OfficeId = 3 },
                new Asset { Id = 18, Type = "Computer", Brand = "Asus", Model = "ROG 500", Price = 1200, PurchaseDate = new DateTime(2022, 3, 5).Date, OfficeId = 3 },
                new Asset { Id = 19, Type = "Computer", Brand = "Asus", Model = "ROG 500", Price = 1200, PurchaseDate = new DateTime(2022, 4, 5).Date, OfficeId = 3 },
                new Asset { Id = 20, Type = "Computer", Brand = "Asus", Model = "ROG 500", Price = 1300, PurchaseDate = new DateTime(2022, 2, 5).Date, OfficeId = 3 }
            );
        }
    }    
}
