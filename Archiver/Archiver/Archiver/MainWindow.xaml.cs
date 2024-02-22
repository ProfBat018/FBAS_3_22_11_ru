using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Archiver
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string SelectFile()
        {
            string? fileName = null;

            var openFileDialog = new OpenFileDialog();


            if (openFileDialog.ShowDialog() != null)
            {
                fileName = openFileDialog.FileName;
            }

            return fileName ?? throw new NullReferenceException("File is null");
        }
        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            using var fs = File.Open(SelectFile(), FileMode.Open);
            using var ms = new MemoryStream();

            fs.CopyTo(ms);

            byte[] fileBytes = ms.ToArray();


        }

        private void Archive_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Unarchive_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
