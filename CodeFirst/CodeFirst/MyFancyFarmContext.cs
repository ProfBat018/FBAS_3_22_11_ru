using Microsoft.EntityFrameworkCore;

namespace CodeFirst;

public class MyFancyFarmContext : DbContext
{
    public DbSet<Animal> Animals { get; set; }
    public DbSet<AnimalType> AnimalTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=MyFancyFarm;User Id=sa;Password=Elvin123;Trust Server Certificate=true;");
    }
}