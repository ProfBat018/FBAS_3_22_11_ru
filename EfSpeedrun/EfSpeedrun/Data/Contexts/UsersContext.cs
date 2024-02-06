using EfSpeedrun.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace EfSpeedrun.Data.Contexts;

public class UsersContext : DbContext
{
    public UsersContext()
    {
        
    }
    public UsersContext(DbContextOptions<UsersContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
}