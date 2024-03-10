namespace WebServer.Services;

public class SampleRequest
{
    private readonly HttpClient _client;

    public SampleRequest()
    {
        _client = new();
    }

    public async Task<string> GetData()
    {
        // Базовый адресс моего запроса
        _client.BaseAddress = new("https://httpbin.org/get");

        // Объект для создания сообщения, который я пошлю 
        HttpRequestMessage message = new();
        
        // HTTP метод. HttpMethod - это enum 
        message.Method = HttpMethod.Get;
        
        // Добавляю заголовок "Id" со значением "1"
        message.Headers.Add("Id", "1");
        
        // HttpResponseMessage - это класс для описания ответа со стороны сервера 
        HttpResponseMessage response = _client.Send(message);

        // Данный метод пробросит HttpRequestException, если выйдет какая-то проблема
        // Такой способ уменьшает кол-во кода, который я пишу 
        response.EnsureSuccessStatusCode();
        
        Console.WriteLine("Headers");
        foreach (var item in response.Headers)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

        Console.WriteLine("Body");

        var responseBody = await response.Content.ReadAsStringAsync();

        Console.WriteLine(responseBody);

        return responseBody;
    }
    
}