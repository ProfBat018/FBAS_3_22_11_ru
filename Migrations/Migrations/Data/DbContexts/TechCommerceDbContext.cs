using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Migrations.Data.DbContexts;

public class TechCommerceDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public DbSet<Product> Products { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configurationBuilder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
        
        var configuration = configurationBuilder.Build();
        
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("Default"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var user = modelBuilder.Entity<User>();

        user.HasKey(x => x.Id);
        user.Property(x => x.Email).IsRequired();
    }
}