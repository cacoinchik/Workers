using Microsoft.EntityFrameworkCore;

namespace Workers.Models
{
    public class WorkersDbContext : DbContext
    {
        public WorkersDbContext(DbContextOptions<WorkersDbContext> options) : base(options)
        {
            
        }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Children> Childrens { get; set; }
    }
}
