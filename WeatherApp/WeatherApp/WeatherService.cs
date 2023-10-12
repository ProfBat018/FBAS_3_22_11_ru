using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp;
static class WeatherService
{
    public static Forecast GetForecast(string cityName)
    {
        string url = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&appid=2b1fd2d7f77ccf1b7de9b441571b39b8&units=metric";

		try
		{
			string json = DownloadService.DownloadJson(url);
			Forecast forecast = DeserializeService.DeserializeJson<Forecast>(json);
			
			return forecast;
		}
		catch (Exception)
		{
			throw;
		}
    }
}
