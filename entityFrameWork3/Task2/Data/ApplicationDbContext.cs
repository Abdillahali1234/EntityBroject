using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Models;
using Task2.ModelsConfiguration;

namespace Task2.Data
{
    internal class ApplicationDbContext:DbContext
    {
        public DbSet<Product> products {  get; set; }
        public DbSet<Customer> customers
        {
            get; set;
        }
        public DbSet<Store> stores
        {
            get; set;
        }
        public DbSet<Sales> sales
        {
            get; set;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"
               Server=.;
                Database=SalesDataBase;
                   Integrated Security=True;
                    Trust Server Certificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new CustomerConfiguration()
                .Configure(modelBuilder.Entity<Customer>());
            new ProductConfiguration()
               .Configure(modelBuilder.Entity<Product>());
            new StoreConfiguration()
                      .Configure(modelBuilder.Entity<Store>());

            new SalesConfiguration()
                 .Configure(modelBuilder.Entity<Sales>());

        }
    }
}
