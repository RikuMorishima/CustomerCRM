using Antra.CustomerCRM.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Infrastructure.Data
{
    public class CustomerCrmDbContext :DbContext
    {
        public CustomerCrmDbContext(DbContextOptions<CustomerCrmDbContext> options):base(options)
        {          
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Product>()
            //    .HasKey(nameof(Product.Id), nameof(Product.VendorId),
            //    nameof(Product.CategoryId), nameof(Product.SupplierId));

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}
