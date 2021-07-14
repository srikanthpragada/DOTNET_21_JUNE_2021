using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace efdemo.Model
{
    class TrainingContext : DbContext 
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Topic> Topics { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // Log SQL commands on to Console 
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

            // Connect to LocalDB database 
            optionsBuilder.UseSqlServer
                (@"Data source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True");
        }
    }
}
