using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webdemo.Model
{
    public class InventoryContext : DbContext 
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True;MultipleActiveResultSets=True");
        }
    }
}
