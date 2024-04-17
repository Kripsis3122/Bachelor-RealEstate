using Microsoft.EntityFrameworkCore;
using RealEstate1.Models;

namespace RealEstate1.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Estate> Estates { get; set; }
    }
}
