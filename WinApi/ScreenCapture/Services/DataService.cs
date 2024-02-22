using DataLayer.DbContexts;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenCapture.Services
{
    internal class DataService
    {
        private readonly ImageDbContext _context;

        public DataService(ImageDbContext context)
        {
            _context = context;
        }

        public void AddImage(ImageModel image)
        {
            _context.ImagesInfo.Add(image);
            _context.SaveChanges();
        }
    }
}
