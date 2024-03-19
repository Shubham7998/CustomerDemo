using CustomerDemo.Model;
using EmployeeDemo.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CustomerDemo.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer>  Customers { get; set; }

        public DbSet<Employee>  Employees { get; set; }

        
    }
}
