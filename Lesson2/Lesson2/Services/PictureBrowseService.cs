using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Services
{
    public static class PictureBrowseService
    {
        public static string BrowseForPicture()
        {
            var fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp";

            DialogResult res = fileDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            else
            {
                return "poster.png";
            }
        }
    }
}
