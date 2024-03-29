﻿using Microsoft.EntityFrameworkCore;
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
