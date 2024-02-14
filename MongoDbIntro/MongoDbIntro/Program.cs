#region DataReading

/*
 Чтобы взять данные из коллекции, достаточно
 обратиться к нужной бд и коллекции.

 Для подключения как всегда понадобится ConnectionString
*/

using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

var connectionString = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build()
    .GetConnectionString("Restaurants");

var client = new MongoClient(connectionString); // Подключение к серверу

var restaurants = client.GetDatabase("sample_restaurants")
    .GetCollection<BsonDocument>("restaurants");
var neighborhoods = client.GetDatabase("sample_restaurants")
    .GetCollection<BsonDocument>("neighborhoods");

// Давайте найдем ресторан с кошерной кухней
var res = restaurants.AsQueryable()
    .Where(x => x["cuisine"] == "Jewish/Kosher")
    .Select(x => x["name"]).ToList();

foreach (var item in res)
{
    Console.WriteLine(item);
}

#endregion



