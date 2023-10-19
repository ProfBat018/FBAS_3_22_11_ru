﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NavigationPages.Services
{
    internal class DownloadService
    {
        public static string Download(string url)
        {
            using var client = new WebClient();

            try
            {
                return client.DownloadString(url) ?? throw new NullReferenceException();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
