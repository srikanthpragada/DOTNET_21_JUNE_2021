using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Model
{
    public class CatalogContext : DbContext 
    {
        public DbSet<Book> Books { get; set; }
        public string ConnectionString { get; set; }
        public CatalogContext(IConfiguration Configuration)
        {
            ConnectionString = Configuration.GetConnectionString("CatalogConnection");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ConnectionString);
        }
    }
}
