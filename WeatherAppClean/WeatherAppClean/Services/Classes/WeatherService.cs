using WeatherAppClean.Models.Classes;
using WeatherAppClean.Models.Interfaces;

namespace WeatherAppClean.Services.Classes;

public class WeatherService<T> where T : IWeather
{
    private readonly ApiService _apiService = new();
    private readonly DeserializeService<T> _deserializeService = new();
    private Dictionary<string, EntityApiPath> _entityApiPaths = new();

    public WeatherService()
    {
        _entityApiPaths.Add("open",
            new EntityApiPath("https://api.openweathermap.org/data/2.5/weather?q=",
                "2b1fd2d7f77ccf1b7de9b441571b39b8"));
        
        _entityApiPaths.Add("bing",
            new EntityApiPath("https://api.bing.microsoft.com/v7.0/weather/forecast?q=",
                "b1b15e88fa797225412429c1c50c122a1"));
    }

    public T GetWeatherByCity(string cityName)
    {
        var type = typeof(T);
        
        string url = type switch
        {
            not null when type == typeof(WeatherForecastOpen) =>
                $"{_entityApiPaths["open"].Link}{cityName}&appid={_entityApiPaths["open"].Key}&units=metric",
            not null when type == typeof(WeatherForecastBinq) =>
                $"{_entityApiPaths["binq"].Link}&city={cityName}&key={_entityApiPaths["binq"].Key}",
            _ => throw new Exception("Unknown type")
        };

        try
        {
            string json = _apiService.GetData(url);
            return _deserializeService.Deserialize(json);
        }
        catch (Exception e)
        {
            throw;
        }        
    }
}