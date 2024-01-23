using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FancyFarmMain.Services.Data;

public class DataConnectionService
{
    private readonly IConfigurationBuilder _builder;

    public DataConnectionService(IConfigurationBuilder builder)
    {
        _builder = builder;
    }

    public DbContextOptions<T> Configure<T>(string connectionName) where T : DbContext
    {
        _builder.AddJsonFile("appsettings.json");

        var config = _builder.Build();
        var connectionString = config.GetConnectionString(connectionName);

        var optionsBuilder = new DbContextOptionsBuilder<T>();
        optionsBuilder.UseSqlServer(connectionString);

        return optionsBuilder.Options;
    }
}