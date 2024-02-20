using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ScreenCapture
{
    class ImageService
    {
        public async Task UploadImage(string path)
        {

            var clientId = "85950ad16f050cc";
            var clientSecret = "e857cca8786575af7c5495d285d9d6306f7f6074";
           
            var options = new RestClientOptions("https://api.imgur.com")
            {
                MaxTimeout = -1,
            };

            var client = new RestClient(options);
            var request = new RestRequest("/3/image", Method.Post);
            request.AddHeader("Authorization", "Client-ID {{clientId}}");
            request.AlwaysMultipartFormData = true;
            request.AddFile("image", path);
            request.AddParameter("type", "image");
            request.AddParameter("title", $"Screenshot: {DateTime.Now}");
            RestResponse response = await client.ExecuteAsync(request);
            MessageBox.Show(response.Content);
        }
    }
}
