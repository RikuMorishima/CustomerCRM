﻿using Antra.CustomerCRM.Core.Entities;
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

        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
    }
}
