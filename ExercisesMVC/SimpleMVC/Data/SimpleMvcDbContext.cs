using Microsoft.EntityFrameworkCore;
using SimpleMVC.Data.Entities;
using SimpleMVC.Models;
using System.Text.RegularExpressions;

namespace SimpleMVC.Data
{
    public class SimpleMvcDbContext : DbContext
    {
        public SimpleMvcDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductReview>().HasKey(nameof(ProductReview.ProductID), nameof(ProductReview.UserID));
        }
    }
}
