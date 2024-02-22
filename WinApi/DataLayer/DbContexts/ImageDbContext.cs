using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DbContexts
{
    public class ImageDbContext : DbContext
    {
        public DbSet<ImageModel> ImagesInfo { get; set; }

        public ImageDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=profbat018_; User Id=profbat018_; Password=Elvin123; Trust Server Certificate=True;");
        }
    }
}
