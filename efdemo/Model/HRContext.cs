using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace efdemo.Model 
{
    class HRContext : DbContext 
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FulltimeEmployee> FulltimeEmployees { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // Log SQL commands on to Console 
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

            // Connect to LocalDB database 
            optionsBuilder.UseSqlServer
                (@"Data source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True;MultipleActiveResultSets=true");
             
        }
    }
}
