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
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample_db");
        }

    }
}
