using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp;
static class DownloadService
{
    public static string DownloadJson(string url)
    {
        try
        {
            var client = new WebClient();
            var res = client.DownloadString(url);

            return res ?? throw new ArgumentNullException("Json is null");
        }
        catch (Exception)
        {
            throw;
        }
    }

 
   
}
