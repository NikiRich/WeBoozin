using Microsoft.EntityFrameworkCore;
using WeBoozin.Models;
namespace WeBoozin.Data

{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Tracker> Tracker { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Vodka", CategoryImage = "/Photos/Vodka.webp" },
                new Category { CategoryId = 2, CategoryName = "Tequila", CategoryImage = "/Photos/Tequila.webp" },
                new Category { CategoryId = 3, CategoryName = "Beer", CategoryImage = "/Photos/Beer.webp" },
                new Category { CategoryId = 4, CategoryName = "Whiskey", CategoryImage = "/Photos/Whiskey.webp" },
                new Category { CategoryId = 5, CategoryName = "Gin", CategoryImage = "/Photos/Gin.webp" },
                new Category { CategoryId = 6, CategoryName = "Rum", CategoryImage = "/Photos/Rum3.webp" },
                new Category { CategoryId = 7, CategoryName = "Liquor", CategoryImage = "/Photos/Liquor.webp" },
                new Category { CategoryId = 8, CategoryName = "Wine", CategoryImage = "/Photos/Wine2.webp" },
                new Category { CategoryId = 9, CategoryName = "Champagne", CategoryImage = "/Photos/Champagne2.webp" }
            );
        }
    }
}
