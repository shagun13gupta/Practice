using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;

namespace Plugins.DataStore.SQL
{
    public class MarketContext:DbContext
    {
        public MarketContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasMany(c => c.Products).
                WithOne(p => p.Category).
                HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Category>().HasData(
                new Category { categoryId = 1, Name = "Bakery", description = "Party Snacks" },
                new Category { categoryId = 2, Name = "Lunch", description = "Wedding" },
                new Category { categoryId = 3, Name = "Dinner", description = "Birthday" });

            modelBuilder.Entity<Product>().HasData(
                 new Product { ProductId = 1, CategoryId = 1, Name = "Ice Tea", Quantity = 10, Price = 30 },
                new Product { ProductId = 2, CategoryId = 1, Name = "Canada Tea", Quantity = 30, Price = 90 },
                new Product { ProductId = 3, CategoryId = 2, Name = "Burger", Quantity = 20, Price = 20 });

        }        


    }
}
