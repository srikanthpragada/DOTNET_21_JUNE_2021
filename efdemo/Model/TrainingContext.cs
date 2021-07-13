using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace efdemo.Model
{
    class TrainingContext : DbContext 
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            optionsBuilder.UseSqlServer
                (@"Data source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True");
        }
    }
}
