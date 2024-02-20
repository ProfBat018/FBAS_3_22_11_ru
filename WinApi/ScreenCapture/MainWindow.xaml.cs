using CaptureWinApi;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace ScreenCapture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Drawing.Image screenshotImage;
        private string pathToSave;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Screenshot_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

            Thread.Sleep(1000);
            screenshotImage = ScreenCapturer.CaptureDesktop();
        }

        private void AppCapture_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveToFile_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != null)
            {
                pathToSave = saveFileDialog.FileName;
                screenshotImage.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
        }

        private void UploadToServer_Click(object sender, RoutedEventArgs e)
        {
            ImageService imageService = new();
            imageService.UploadImage(pathToSave);
        }
    }
}
