using System;
using System.Net.Http;
using BookCenter.Services.Interfaces;
using System.IO;

namespace BookCenter.Services.Classes;

class DownloadService : IDownloadService
{
    public string DownloadData(string title = "", int page = 1)
    {
        var urlWithTitle = $"https://book-finder1.p.rapidapi.com/api/search?title={title}&lexile_min=600&lexile_max=800&results_per_page=10&page={page}";
        var urlWithoutTitle = $"https://book-finder1.p.rapidapi.com/api/search?series=Wings%20of%20fire&book_type=Fiction&lexile_min=600&lexile_max=800&results_per_page=10&page={page}";


        var url = title == "" ? urlWithoutTitle : urlWithTitle;

        var client = new HttpClient();

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url),
            Headers =
                    {
                        { "X-RapidAPI-Key", "1ffacf9737mshbb4164b9741187ep1ed703jsn0ece4656d4c4" },
                        { "X-RapidAPI-Host", "book-finder1.p.rapidapi.com" },
                    },
        };

        using var response = client.Send(request);

        response.EnsureSuccessStatusCode();

        var stream = response.Content.ReadAsStream();

        using StreamReader sr = new(stream);

        var body = sr.ReadToEnd();

        return body ?? throw new Exception("No data found");
    }
}
