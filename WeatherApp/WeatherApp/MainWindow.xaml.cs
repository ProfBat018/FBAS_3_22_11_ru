using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeatherApp
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            var searchRes = WeatherService.GetForecast(cityName.Text);


            tempLabel.Content = searchRes.Main.Temp;
            feelsLikeLabel.Content = searchRes.Main.FeelsLike;
            windSpeedLabel.Content = searchRes.Wind.Speed;
            pressureLabel.Content = searchRes.Main.Pressure;

            weatherImg.Source = $"http://openweathermap.org/img/w/{searchRes.Weather[0].Icon}.png";
        }
    }
}
