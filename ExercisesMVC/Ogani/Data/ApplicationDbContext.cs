using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ogani.Data.Entities;
using System.Reflection.Emit;

namespace Ogani.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }


		protected override void OnModelCreating(ModelBuilder Builder)
		{
            base.OnModelCreating(Builder);
        }
	}
}