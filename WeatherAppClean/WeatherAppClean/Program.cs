using WeatherAppClean.Models.Classes;
using WeatherAppClean.Services.Classes;

WeatherService<WeatherForecastOpen> weatherService = new();

var res = weatherService.GetWeatherByCity("Baku");

Console.WriteLine(res.main.temp);
Console.WriteLine(res.main.feels_like);






