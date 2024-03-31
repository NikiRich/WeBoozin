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
                new Category { CategoryId = 6, CategoryName = "Rum", CategoryImage = "/Photos/Rum.webp" },
                new Category { CategoryId = 7, CategoryName = "Liquor", CategoryImage = "/Photos/Liquor.webp" },
                new Category { CategoryId = 8, CategoryName = "Wine", CategoryImage = "/Photos/Wine.webp" },
                new Category { CategoryId = 9, CategoryName = "Champagne", CategoryImage = "/Photos/Champagne.webp" }
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
                },
                new Product
                {
                    ProductId = 28,
                    ProductName = "Gentleman's Choice",
                    Description = "The choice of every gentleman.",
                    Image = "/Photos/Whiskey1.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId = 29,
                    ProductName = "Dark Wolf",
                    Description = "Free the wolf inside you with this fine whiskey.",
                    Image = "/Photos/Whiskey2.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 45,
                    QuantityInStock = 50,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId = 30,
                    ProductName = "Irish Pride",
                    Description = "Feel the pride of Ireland with this whiskey.",
                    Image = "/Photos/Whiskey3.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId = 31,
                    ProductName = "United Together",
                    Description = "Crafted to unite the world.",
                    Image = "/Photos/Whiskey4.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 38,
                    QuantityInStock = 50,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId = 32,
                    ProductName = "Infinity",
                    Description = "Dive into the infinity with this whiskey.",
                    Image = "/Photos/Whiskey5.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId = 33,
                    ProductName = "Golden Age of Whiskey",
                    Description = "Symbolizes the good old times through its unique taste.",
                    Image = "/Photos/Whiskey6.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 42,
                    QuantityInStock = 50,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId = 34,
                    ProductName = "Royal Choice",
                    Description = "The choice of every royal family.",
                    Image = "/Photos/Whiskey7.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 43,
                    QuantityInStock = 50,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId = 35,
                    ProductName = "Dark Night",
                    Description = "Crafted to be enjoyed in the dark night.",
                    Image = "/Photos/Whiskey8.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId = 36,
                    ProductName = "Shooter's",
                    Description = "Become the shooter you always wanted to be.",
                    Image = "/Photos/Whiskey9.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 38,
                    QuantityInStock = 50,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId = 37,
                    ProductName = "Morning Dew",
                    Description = "Feel the freshness of morning dew with this gin.",
                    Image = "/Photos/Gin1.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 5
                },
                new Product
                {
                    ProductId = 38,
                    ProductName = "Sunset on the Beach",
                    Description = "Feel the atmosphere of sunset on the beach with this gin.",
                    Image = "/Photos/Gin2.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 35,
                    QuantityInStock = 50,
                    CategoryId = 5
                },
                new Product
                {
                    ProductId = 39,
                    ProductName = "Ice Bath",
                    Description = "Feel the chill of ice bath with this gin.",
                    Image = "/Photos/Gin3.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 43,
                    QuantityInStock = 50,
                    CategoryId = 5
                },
                new Product
                {
                    ProductId = 40,
                    ProductName = "Alligator",
                    Description = "For adventurous souls only.",
                    Image = "/Photos/Gin4.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 5
                },
                new Product
                {
                    ProductId = 41,
                    ProductName = "Serenity",
                    Description = "Brings calmness and tranquility to your soul.",
                    Image = "/Photos/Gin5.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 38,
                    QuantityInStock = 50,
                    CategoryId = 5
                },
                new Product
                {
                    ProductId = 42,
                    ProductName = "Fury",
                    Description = "Adrenaline rush in a bottle.",
                    Image = "/Photos/Gin6.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 45,
                    QuantityInStock = 50,
                    CategoryId = 5
                },
                new Product
                {
                    ProductId = 43,
                    ProductName = "Britih Punch",
                    Description = "Feel the British punch with this gin.",
                    Image = "/Photos/Gin7.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 5
                },
                new Product
                {
                    ProductId = 44,
                    ProductName = "Texas Heat",
                    Description = "Feel the heat of Texas with this gin.",
                    Image = "/Photos/Gin8.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 45,
                    QuantityInStock = 50,
                    CategoryId = 5
                },
                new Product
                {
                    ProductId = 45,
                    ProductName = "Nature Calls",
                    Description = "Answer the call of nature and live peacefully with your inner self.",
                    Image = "/Photos/Gin9.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 5
                },
                new Product
                {
                    ProductId = 46,
                    ProductName = "Pirate's Choice",
                    Description = "The choice of every pirate.",
                    Image = "/Photos/Rum1.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 6
                },
                new Product
                {
                    ProductId = 47,
                    ProductName = "Sea Storm",
                    Description = "Feel ocean's power with every sip.",
                    Image = "/Photos/Rum2.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 42,
                    QuantityInStock = 50,
                    CategoryId = 6
                },
                new Product
                {
                    ProductId = 48,
                    ProductName = "Caribbean Night",
                    Description = "Feel the tranquility of Caribbean night with this rum.",
                    Image = "/Photos/Rum3.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 38,
                    QuantityInStock = 50,
                    CategoryId = 6
                },
                new Product
                {
                    ProductId = 49,
                    ProductName = "Partygoer",
                    Description = "For true partygoers only.",
                    Image = "/Photos/Rum4.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 6
                },
                new Product
                {
                    ProductId = 50,
                    ProductName = "Stellar",
                    Description = "Taste from a different galaxy.",
                    Image = "/Photos/Rum5.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 38,
                    QuantityInStock = 50,
                    CategoryId = 6
                },
                new Product
                {
                    ProductId = 51,
                    ProductName = "Eclipse",
                    Description = "Feel the mesmerizing beauty of an eclipse with this rum.",
                    Image = "/Photos/Rum6.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 6
                },
                new Product
                {
                    ProductId = 52,
                    ProductName = "Voyager",
                    Description = "For real explorers of the world.",
                    Image = "/Photos/Rum7.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 42,
                    QuantityInStock = 50,
                    CategoryId = 6
                },
                new Product
                {
                    ProductId = 53,
                    ProductName = "Dreamer",
                    Description = "Become a dreamer with the first sip of this rum.",
                    Image = "/Photos/Rum8.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 40,
                    QuantityInStock = 50,
                    CategoryId = 6
                },
                new Product
                {
                    ProductId = 54,
                    ProductName = "Sunny Way",
                    Description = "Feel the warmth and vitality with every sip.",
                    Image = "/Photos/Rum9.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 38,
                    QuantityInStock = 50,
                    CategoryId = 6
                },
                new Product
                {
                    ProductId = 55,
                    ProductName = "Oriental Night",
                    Description = "Live and enjoy through the Oriental night with this liquor.",
                    Image = "/Photos/Liquor1.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 35,
                    QuantityInStock = 50,
                    CategoryId = 7
                },
                new Product
                {
                    ProductId = 56,
                    ProductName = "Dancing Star",
                    Description = "Become the dancing star of the night with this liquor.",
                    Image = "/Photos/Liquor2.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 33,
                    QuantityInStock = 50,
                    CategoryId = 7
                },
                new Product
                {
                    ProductId = 57,
                    ProductName = "Sweet Fruit",
                    Description = "Taste the sophisticated sweetness of fruits.",
                    Image = "/Photos/Liquor3.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 30,
                    QuantityInStock = 50,
                    CategoryId = 7
                },
                new Product
                {
                    ProductId = 58,
                    ProductName = "Passion",
                    Description = "Ignite the spark of passion inside you.",
                    Image = "/Photos/Liquor4.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 35,
                    QuantityInStock = 50,
                    CategoryId = 7
                },
                new Product
                {
                    ProductId = 59,
                    ProductName = "Garden Bloom",
                    Description = "Taste like a garden in full bloom.",
                    Image = "/Photos/Liquor5.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 33,
                    QuantityInStock = 50,
                    CategoryId = 7
                },
                new Product
                {
                    ProductId = 60,
                    ProductName = "Albino",
                    Description = "White as snow. Pure as a soul.",
                    Image = "/Photos/Liquor6.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 33,
                    QuantityInStock = 50,
                    CategoryId = 7
                },
                new Product
                {
                    ProductId = 61,
                    ProductName = "Extravaganza",
                    Description = "For an extravagant soul ready to dive into the unknown.",
                    Image = "/Photos/Liquor7.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 35,
                    QuantityInStock = 50,
                    CategoryId = 7
                },
                new Product
                {
                    ProductId = 62,
                    ProductName = "Night Sky",
                    Description = "The taste is as beautiful as the night sky.",
                    Image = "/Photos/Liquor8.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 34,
                    QuantityInStock = 50,
                    CategoryId = 7
                },
                new Product
                {
                    ProductId = 63,
                    ProductName = "Champ's",
                    Description = "Tje choice of every champion.",
                    Image = "/Photos/Liquor9.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 35,
                    QuantityInStock = 50,
                    CategoryId = 7
                },
                new Product
                {
                    ProductId = 64,
                    ProductName = "Trinity",
                    Description = "Sophistication and unity.",
                    Image = "/Photos/Wine1.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 12,
                    QuantityInStock = 50,
                    CategoryId = 8
                },
                new Product
                {
                    ProductId = 65,
                    ProductName = "Elegant Romance",
                    Description = "Feel the elegance and romance in every sip.",
                    Image = "/Photos/Wine2.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 12.5,
                    QuantityInStock = 50,
                    CategoryId = 8
                },
                new Product
                {
                    ProductId = 66,
                    ProductName = "Red Temptation",
                    Description = "You won't be able to resist this wine.",
                    Image = "/Photos/Wine3.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 13.3,
                    QuantityInStock = 50,
                    CategoryId = 8
                },
                new Product
                {
                    ProductId = 67,
                    ProductName = "White Energy",
                    Description = "Overflowing with energy and freshness.",
                    Image = "/Photos/Wine4.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 11.5,
                    QuantityInStock = 50,
                    CategoryId = 8
                },
                new Product
                {
                    ProductId = 68,
                    ProductName = "Queen's Throne",
                    Description = "Premium wine for the queen in you.",
                    Image = "/Photos/Wine5.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 12.8,
                    QuantityInStock = 50,
                    CategoryId = 8
                },
                new Product
                {
                    ProductId = 69,
                    ProductName = "Red Crown",
                    Description = "Feel the royalty with every bottle.",
                    Image = "/Photos/Wine6.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 13,
                    QuantityInStock = 50,
                    CategoryId = 8
                },
                new Product
                {
                    ProductId = 70,
                    ProductName = "White Rose",
                    Description = "Purity and excellence in every glass",
                    Image = "/Photos/Wine7.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 11.9,
                    QuantityInStock = 50,
                    CategoryId = 8
                },
                new Product
                {
                    ProductId = 71,
                    ProductName = "Gold Rose",
                    Description = "Rare and precious like gold.",
                    Image = "/Photos/Wine8.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 12.5,
                    QuantityInStock = 50,
                    CategoryId = 8
                },
                new Product
                {
                    ProductId = 72,
                    ProductName = "Cozy Night",
                    Description = "Let's you crete the atmosphere to share with your loved ones.",
                    Image = "/Photos/Wine9.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 12.3,
                    QuantityInStock = 50,
                    CategoryId = 8
                },
                new Product
                {
                    ProductId = 73,
                    ProductName = "Royal Club",
                    Description = "The choice of every royal family.",
                    Image = "/Photos/Champagne1.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 12.5,
                    QuantityInStock = 50,
                    CategoryId = 9
                },
                new Product
                {
                    ProductId = 74,
                    ProductName = "Rich",
                    Description = "Feel the rich taste of this champagne.",
                    Image = "/Photos/Champagne2.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 12.6,
                    QuantityInStock = 50,
                    CategoryId = 9
                },
                new Product
                {
                    ProductId = 75,
                    ProductName = "Russian Nobility",
                    Description = "Feel yourself like a Russian noble with this champagne.",
                    Image = "/Photos/Champagne3.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 12,
                    QuantityInStock = 50,
                    CategoryId = 9
                },
                new Product
                {
                    ProductId = 76,
                    ProductName = "Dynasty",
                    Description = "Stong and powerful like a dynasty.",
                    Image = "/Photos/Champagne4.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 13.8,
                    QuantityInStock = 50,
                    CategoryId = 9
                },
                new Product
                {
                    ProductId = 77,
                    ProductName = "Desire",
                    Description = "Invoke the desire for something you deserve.",
                    Image = "/Photos/Champagne5.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 12.5,
                    QuantityInStock = 50,
                    CategoryId = 9
                },
                new Product
                {
                    ProductId = 78,
                    ProductName = "Rare Glory",
                    Description = "Rare and glorious like a diamond.",
                    Image = "/Photos/Champagne6.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 14,
                    QuantityInStock = 50,
                    CategoryId = 9
                },
                new Product
                {
                    ProductId = 79,
                    ProductName = "Apennini",
                    Description = "Fine Italian champagne for the connoisseurs.",
                    Image = "/Photos/Champagne7.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 13.7,
                    QuantityInStock = 50,
                    CategoryId = 9
                },
                new Product
                {
                    ProductId = 80,
                    ProductName = "Guilty Pleasure",
                    Description = "The pleasure you won't be able to resist.",
                    Image = "/Photos/Champagne8.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 14.5,
                    QuantityInStock = 50,
                    CategoryId = 9
                },
                new Product
                {
                    ProductId = 81,
                    ProductName = "Last Romance",
                    Description = "Makes you enjoy every sip like it was your last romance",
                    Image = "/Photos/Champagne9.webp",
                    QuantityInMl = 750,
                    AlcoholContent = 13.4,
                    QuantityInStock = 50,
                    CategoryId = 9
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
