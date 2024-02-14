using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace MongoDbIntro.Services;

public class DbService
{
    private readonly MongoClient _client;
    
    public DbService()
    {
        var connectionString = new ConfigurationBuilder()
            .Build()
            .GetConnectionString("Restaurants");
        
        _client = new MongoClient(connectionString);
    }
    
}