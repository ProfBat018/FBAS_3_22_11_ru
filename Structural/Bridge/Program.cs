using Bridge.Model;
using Bridge.Services;


ITransport transport = TransportService.CreateTransport();

Console.WriteLine(transport);

var props = transport.TransportEntity.GetMetadata();

foreach (var prop in props)
{
    Console.WriteLine($"{prop.Name} {prop.PropertyType}");
}