using WeatherApp;

WeatherDataService service = new();

try
{
    WeatherData data = service.GetWeatherByCity("Baku");
    
    Console.WriteLine($"City: {data.name}");
    Console.WriteLine($"Temperature: {data.main.temp}°C");
    Console.WriteLine($"Feels like: {data.main.feels_like}°C");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

