using LinqWithEfCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithEfCore
{
    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(
            Environment.CurrentDirectory,"DataBase", "Northwind.db");
            optionsBuilder.UseSqlite($"Filename={path}");
            /*
            string connection = "Data Source=.;" +
            "Initial Catalog=Northwind;" +
            "Integrated Security=true;" +
            "MultipleActiveResultSets=true;";
            optionsBuilder.UseSqlServer(connection);
            */
        }
        protected override void OnModelCreating(
        ModelBuilder modelBuilder)
        {
            if ((Database.ProviderName is not null)
            && (Database.ProviderName.Contains("Sqlite")))
            {
                modelBuilder.Entity<Product>()
                .Property(product => product.UnitPrice)
                .HasConversion<double>();
            }
        }

    }
}
