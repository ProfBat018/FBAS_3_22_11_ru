using GalaSoft.MvvmLight.Command;
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

namespace FuncsToPointerExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        public string Text { get; set; } = "Famil 👽";

        void ShowMessageForFamil()
        {
            var res = MessageBox.Show("Фамиль хочет 1 балл ?", "Шалом", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes || res == MessageBoxResult.No)
            {
                MessageBox.Show("Ты по любому получишь 1 балл )) ", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public RelayCommand ClickMeCommand 
        {
            get => new(ShowMessageForFamil);
        }


        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
