using Microsoft.EntityFrameworkCore;
using WeBoozin.Models;
namespace WeBoozin.Data

{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(){}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Tracker> Trackers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
