using E_BookStoreUi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_BookStoreUi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Genre> Genres   {get;set;}

        public DbSet<Book> Books {get;set;}

        public DbSet<ShoppingCard>  ShoppingCards  {get;set;}

        public DbSet<CardDetail> CardDetails   {get;set;}

        public DbSet<Order> Orders  {get;set;}

        public DbSet<OrderDetail> OrderDetails  {get;set;}

        public DbSet<OrderStatus> OrderStatuses  {get;set;}



}
}