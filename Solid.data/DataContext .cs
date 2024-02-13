using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;

namespace Solid.Data
{

                  
    public class DataContext:DbContext
    {
        public DbSet<Transactions> transactions { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<SaleAndRenting> saleAndRenting { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=yael1_db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transactions>().HasOne(x => x.Seller).WithMany().HasForeignKey(x => x.SellerId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Transactions>().HasOne(x => x.Customer).WithMany().HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
