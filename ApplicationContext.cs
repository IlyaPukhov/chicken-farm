using ChickenFarm.Models;
using Microsoft.EntityFrameworkCore;

namespace ChickenFarm
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Chicken> Chickens { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=chicken_farm;Username=postgres;Password=postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(u => u.DismissalDate).HasDefaultValue(null);
        }
    }
}
