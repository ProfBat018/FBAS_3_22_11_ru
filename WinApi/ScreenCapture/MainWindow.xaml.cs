using CaptureWinApi;
using DataLayer.DbContexts;
using Microsoft.Win32;
using ScreenCapture.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ScreenCapture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ImageService _imgService = new();
        private System.Drawing.Image screenshotImage;
        private string pathToSave;

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DeleteObject(IntPtr value);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Screenshot_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

            Thread.Sleep(1000);
            screenshotImage = ScreenCapturer.CaptureDesktop();

            var bitmap = new Bitmap(screenshotImage);
            IntPtr bmpPt = bitmap.GetHbitmap();
            
            BitmapSource bitmapSource =
             System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                   bmpPt,
                   IntPtr.Zero,
                   Int32Rect.Empty,
                   BitmapSizeOptions.FromEmptyOptions());

            ImageBox.Source = bitmapSource;


            bitmapSource.Freeze();
            DeleteObject(bmpPt);

            this.WindowState = WindowState.Normal;
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

        private async void UploadToServer_Click(object sender, RoutedEventArgs e)
        {
            using ImageDbContext context = new();

            var dataService = new DataService(context);
            
            dataService.AddImage(await _imgService.UploadImage(pathToSave));
        }
    }
}
