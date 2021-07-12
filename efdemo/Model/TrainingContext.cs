using Microsoft.EntityFrameworkCore;

namespace efdemo.Model
{
    class TrainingContext : DbContext 
    {
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer
                (@"Data source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True");
        }
    }
}
