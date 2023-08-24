using Microsoft.EntityFrameworkCore;
using WebApkTest1.Models;

namespace WebApkTest1.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {
            
        }


        public DbSet<Category> Categories { get; set; }
    }
}
