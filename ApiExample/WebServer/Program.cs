using WebServer.Models;
using WebServer.Services;

WordService wordService = new();

var res = await wordService.GetSimilar(Console.ReadLine());

Console.WriteLine($"{res.word} is similar to");
foreach (var s in res.similarTo)
{
    Console.WriteLine(s);
}