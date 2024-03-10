using System.Text.Json;
using WebServer.Models;

namespace WebServer.Services;

public class WordService
{
    private readonly HttpClient _client= new();

    public async Task<SimilarResponse> GetSimilar(string word)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"https://wordsapiv1.p.rapidapi.com/words/{word}/similarTo"),
            Headers =
            {
                { "X-RapidAPI-Key", "1ffacf9737mshbb4164b9741187ep1ed703jsn0ece4656d4c4" },
                { "X-RapidAPI-Host", "wordsapiv1.p.rapidapi.com" },
            },
        };
        using HttpResponseMessage response = await _client.SendAsync(request);

        response.EnsureSuccessStatusCode();
        
        var body = await response.Content.ReadAsStreamAsync();

        return await JsonSerializer.DeserializeAsync<SimilarResponse>(body);
    }
}