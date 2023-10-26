using BookCenter.Models;
using BookCenter.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace BookCenter.Services.Classes;

class BookManagerService : IBookManagerService
{
    public BookModel Books { get ; set; }

    private readonly IDownloadService _downloadService;
    private readonly IJsonService _jsonService;


    public BookManagerService(IDownloadService downloadService, IJsonService jsonService)
    {
        _downloadService = downloadService;
        _jsonService = jsonService;
    }


    public BookModel GetBooks(string title = "", int page = 1)
    {
        var json = _downloadService.DownloadData(title, page);
     
        var books = _jsonService.Deserialize<BookModel>(json);

        return books;
    }
}
