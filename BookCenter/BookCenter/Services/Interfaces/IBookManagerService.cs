using BookCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCenter.Services.Interfaces
{
    interface IBookManagerService
    {
        public BookModel Books { get; set; }
        public BookModel GetBooks(string title = "", int page = 1);
    }
}
