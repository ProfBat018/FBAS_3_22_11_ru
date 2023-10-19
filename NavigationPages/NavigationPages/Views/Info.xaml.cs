using NavigationPages.Services;
using System;
using System.Collections.Generic;
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

namespace NavigationPages.Views
{
    /// <summary>
    /// Interaction logic for Info.xaml
    /// </summary>
    public partial class Info : Page
    {
        public Info(Forecast forecast)
        {
            InitializeComponent();

            tempLbl.Content = forecast.Main.Temp;
            feelsLikeLbl.Content = forecast.Main.FeelsLike;
            pressureLbl.Content = forecast.Main.Pressure;
            
            sunriseLbl.Content = DateService
                .GetDateByUnixSeconds(forecast.Sys.Sunrise, forecast.Timezone)
                .ToString("HH:mm:ss");

            sunsetLbl.Content = DateService
                .GetDateByUnixSeconds(forecast.Sys.Sunset, forecast.Timezone)
                .ToString("HH:mm:ss");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();   
        }
    }
}
