using Memento.Services;


WeatherService weatherService = 
    new(new DownloadService("https://api.openweathermap.org/data/2.5/weather?q={cityname}&appid=2b1fd2d7f77ccf1b7de9b441571b39b8&units=metric"), 
    new SnapshotService());

//weatherService.GetWeather("Baku");
//weatherService.GetWeather("Moscow");

Console.WriteLine(weatherService.GetPreviousWeather().main.temp);



