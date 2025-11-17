using Microsoft.EntityFrameworkCore;

namespace HW20_Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=C#_HW_20;Username=postgres");
        }
    }
}