using FancyFarmMain.Services.Data;
using Microsoft.Extensions.Configuration;
using MyFancyFarmDataLayer;

IConfigurationBuilder builder = new ConfigurationBuilder();

var dataConnectionService = new DataConnectionService(builder);

var ops = dataConnectionService.Configure<MyFancyFarmContext>("Default");

using var context = new MyFancyFarmContext(ops);

var animals = context.Animals;

foreach (var item in animals)
{
    Console.WriteLine(item.Name);
}
