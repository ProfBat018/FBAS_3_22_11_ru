using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCenter.Services.Interfaces;

interface IDownloadService
{
    public string DownloadData(string title = "", int page = 1);
}
