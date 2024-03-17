#region HttpClient


HttpClient client = new();

client.BaseAddress = new("http://localhost:5211/addnewbrand");


HttpRequestMessage message = new();

message.Method = HttpMethod.Post;


Console.WriteLine("Enter brand name: ");
message.Headers.Add("brand", Console.ReadLine());

var response = await client.SendAsync(message);

Console.WriteLine(await response.Content.ReadAsStringAsync());



#endregion