using Microsoft.EntityFrameworkCore;
using WebApk2.Models;

namespace WebApk2.Data
{
    public class Aplication2DbContext : DbContext
    {
        public Aplication2DbContext(DbContextOptions<Aplication2DbContext> options) : base(options) 
        {
            

        }


        public DbSet<Category> Categories { get; set; }

    }
}
