using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Policy;
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
        public DbSet<CartItem> CartItems { get; set; }
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
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Purity of Soul",
                    Description = "Feel the purity of your soul through this wonder drink.",
                    Image = "/Photos/Vodka1.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Fire in the Heart",
                    Description = "Feel the fire in your heart with this vodka designed to lit your soul.",
                    Image = "/Photos/Vodka2.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Lightness of Soul",
                    Description = "Feel the lightness in your soul with every sip of this vodka.",
                    Image = "/Photos/Vodka3.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "Freedom of Mind",
                    Description = "Feel the freedom of your mind through after the first sip of this vodka.",
                    Image = "/Photos/Vodka4.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "Victorious",
                    Description = "Feel the victory in your veins with this vodka.",
                    Image = "/Photos/Vodka5.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 6,
                    ProductName = "Russian Power",
                    Description = "Feel the strength in your veins with this vodka.",
                    Image = "/Photos/Vodka6.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 7,
                    ProductName = "Russian Glory",
                    Description = "Feel the glory like a Russian with this vodka.",
                    Image = "/Photos/Vodka7.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 8,
                    ProductName = "Alpha Male",
                    Description = "Become an alpha of your pac after the first sip of this vodka.",
                    Image = "/Photos/Vodka8.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 9,
                    ProductName = "World ELite",
                    Description = "Become an elite with this vodka.",
                    Image = "/Photos/Vodka9.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 10,
                    ProductName = "Latino Fire",
                    Description = "Live through the fire of Latino culture.",
                    Image = "/Photos/Tequila1.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 45,
                    QuantityInStock = 50,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 11,
                    ProductName = "Mexican Pride",
                    Description = "Feel the pride of Mexico with this tequila.",
                    Image = "/Photos/Tequila2.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 37,
                    QuantityInStock = 50,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 12,
                    ProductName = "Fiesta",
                    Description = "Experience the Mexican fiesta at your home.",
                    Image = "/Photos/Tequila3.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 13,
                    ProductName = "Los Bandidos",
                    Description = "From the people. For the people. Live it.",
                    Image = "/Photos/Tequila4.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 42,
                    QuantityInStock = 50,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 14,
                    ProductName = "Blood Money",
                    Description = "Show you have got what it takes to earn it.",
                    Image = "/Photos/Tequila5.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 45,
                    QuantityInStock = 50,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 15,
                    ProductName = "Dia de Muertos",
                    Description = "Celebrate the day of the dead with this tequila.",
                    Image = "/Photos/Tequila6.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 45,
                    QuantityInStock = 50,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 16,
                    ProductName = "El Patron",
                    Description = "Feel like a boss of the table with this tequila.",
                    Image = "/Photos/Tequila7.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 38,
                    QuantityInStock = 50,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 17,
                    ProductName = "Mexican Night",
                    Description = "Live through the Mexican night with this tequila.",
                    Image = "/Photos/Tequila8.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 18,
                    ProductName = "Mexican Sunrise",
                    Description = "Meet and greet the Mexican sunrise with this tequila.",
                    Image = "/Photos/Tequila9.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 19,
                    ProductName = "Pine Forest",
                    Description = "Feel the freshness of pine forest with this beer.",
                    Image = "/Photos/Beer1.webp",
                    QuantityInMl = 500,
                    AlcoholContent = 8.5,
                    QuantityInStock = 50,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 20,
                    ProductName = "Alpine Breeze",
                    Description = "Feel the breeze of Alps with this beer.",
                    Image = "/Photos/Beer2.webp",
                    QuantityInMl = 500,
                    AlcoholContent = 6.5,
                    QuantityInStock = 50,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 21,
                    ProductName = "Fine Brothers",
                    Description = "Crafted with love and dedication by the Fine Brothers.",
                    Image = "/Photos/Beer3.webp",
                    QuantityInMl = 500,
                    AlcoholContent = 7,
                    QuantityInStock = 50,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 22,
                    ProductName = "Golden Wheat",
                    Description = "Brewed from the best golden wheat.",
                    Image = "/Photos/Beer4.webp",
                    QuantityInMl = 500,
                    AlcoholContent = 5.5,
                    QuantityInStock = 50,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 23,
                    ProductName = "Bearish",
                    Description = "Fine dark beer for the bear in you.",
                    Image = "/Photos/Beer5.webp",
                    QuantityInMl = 500,
                    AlcoholContent = 7.5,
                    QuantityInStock = 50,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 24,
                    ProductName = "Quality Time",
                    Description = "Brewed to be enjoyed with friends.",
                    Image = "/Photos/Beer6.webp",
                    QuantityInMl = 500,
                    AlcoholContent = 6,
                    QuantityInStock = 50,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 25,
                    ProductName = "BBQ Master",
                    Description = "Essential beer for every BBQ master.",
                    Image = "/Photos/Beer7.webp",
                    QuantityInMl = 500,
                    AlcoholContent = 8.7,
                    QuantityInStock = 50,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 26,
                    ProductName = "Bavarian",
                    Description = "Brewed in the traditional Bavarian style.",
                    Image = "/Photos/Beer8.webp",
                    QuantityInMl = 500,
                    AlcoholContent = 6.8,
                    QuantityInStock = 50,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 27,
                    ProductName = "Czech Pride",
                    Description = "Finest Dark beer from the Czech Republic.",
                    Image = "/Photos/Beer9.webp",
                    QuantityInMl = 500,
                    AlcoholContent = 7.7,
                    QuantityInStock = 50,
                    CategoryId = 3
                }

               );

            // User to Orders
            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Orders are deleted if User is deleted

            // User to Trackers
            modelBuilder.Entity<User>()
                .HasMany(u => u.Tracker)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Trackers are deleted if User is deleted

            // User to Cart
            modelBuilder.Entity<User>()
                .HasOne(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<Cart>(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Cart is deleted if User is deleted

            // Category to Products
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade); // Products are deleted if Category is deleted

            // Product to OrderDetails
            modelBuilder.Entity<Product>()
                .HasMany(p => p.OrderDetails)
                .WithOne(od => od.Product)
                .HasForeignKey(od => od.ProductId)
                .OnDelete(DeleteBehavior.Cascade); // OrderDetails are deleted if Product is deleted

            // Product to Trackers
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Tracker)
                .WithOne(t => t.Product)
                .HasForeignKey(t => t.ProductId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent deletion of Product if the Product is being tracked

            // Product to CartItems (handled via CartItems model)
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(ci => ci.ProductId)
                .OnDelete(DeleteBehavior.Cascade); // CartItems are deleted if Product is deleted

            // Cart to CartItems
            modelBuilder.Entity<Cart>()
                .HasMany(c => c.CartItems)
                .WithOne(ci => ci.Cart)
                .HasForeignKey(ci => ci.CartId)
                .OnDelete(DeleteBehavior.Cascade); // CartItems are deleted if Cart is deleted

            // Order to OrderDetails
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderDetails)
                .WithOne(od => od.Orders)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Cascade); // OrderDetails are deleted if Order is deleted
        }
    }
}
