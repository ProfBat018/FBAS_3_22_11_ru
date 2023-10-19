using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WeatherApp;
public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private string GetLocalDateOfWeather(int dateSeconds, int timezone)
    {
        return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
            .AddSeconds(dateSeconds)
            .AddSeconds(timezone)
            .ToString("HH:mm:ss");
    }

    private void searchBtn_Click(object sender, RoutedEventArgs e)
    {
        try
        {

            var searchRes = WeatherService.GetForecast(cityName.Text);

            if (searchRes.Main.Temp < 10)
            {
                tempLabel.Style = (Style)FindResource("Cold");
            }
            else if (searchRes.Main.Temp > 20)
            {
                tempLabel.Style = (Style)FindResource("Warm");
            }
            else
            {
                tempLabel.Style = (Style)FindResource("Normal");
            }
            tempLabel.Content = searchRes.Main.Temp;

            feelsLikeLabel.Content = searchRes.Main.FeelsLike;
            windSpeedLabel.Content = searchRes.Wind.Speed;
            pressureLabel.Content = searchRes.Main.Pressure;

            sunriseLabel.Content = GetLocalDateOfWeather(searchRes.Sys.Sunrise, searchRes.Timezone);
            sunsetLabel.Content = GetLocalDateOfWeather(searchRes.Sys.Sunset, searchRes.Timezone);


            weatherImg.Source = new BitmapImage(new Uri($"http://openweathermap.org/img/w/{searchRes.Weather[0].Icon}.png"));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
