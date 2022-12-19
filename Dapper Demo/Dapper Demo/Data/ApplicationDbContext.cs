using DapperDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Data
{
    // This class inherits from the DB context class which inside Microsoft .NET EF Core 
    public class ApplicationDbContext : DbContext
    {
        // ctor - shortcut for the registering constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        // adding property(prop), Companies(adding companies in our database) - name of the table in the Database 
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Write fluent API configurations here

            // Property Configurations
            modelBuilder.Entity<Company>().Ignore(t => t.Employees);

            modelBuilder.Entity<Employee>().HasOne(c => c.Company).WithMany(e => e.Employees).HasForeignKey(c => c.CompanyId);
        }
    }
}
