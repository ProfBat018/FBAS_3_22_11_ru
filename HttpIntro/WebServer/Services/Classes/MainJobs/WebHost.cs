using System.Net;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using WebServer.Controllers;
using WebServer.Middlewares.Classes;
using WebServer.Middlewares.Delegates;
using WebServer.Services.Interfaces;

namespace WebServer.Services.Classes.MainJobs;

public class WebHost : IWebHost
{
    // ServiceProvider - это наш IOC контейнер, как класс Container из пакета SimpleInjector 
    // MiddlewareBuilder - это мой класс, который я создал для создания цепочки обязанностей 
    // HttpListener - это класс, который занимается прослушиванием и обработкой запроса от пользователя 
    // _port - это номер порта, который будет прослушаиваться по адресу 127.0.0.1
    public static ServiceProvider Container; 
    private readonly MiddlewareBuilder _builder;
    private readonly HttpListener _listener;
    private ushort _port;

    // это уже объяснять не буду 
    public WebHost(ushort port)
    {
        _port = port;
        _listener = new();
        _builder = new();
    }

    private void ConfigureServices()
    {
        // Создаю пустую коллекцию из сервисов 
        var collection = new ServiceCollection();

        // Добавляю каждый объект в коллекцию
        collection.AddTransient<LoggerMiddleware>();
        collection.AddTransient<MvcMiddleware>();
        collection.AddTransient<MiddlewareBuilder>();
        collection.AddTransient<HomeController>();
        
        // Добавляю два middleware в цепочку обязанностей 
        _builder.Use<LoggerMiddleware>();
        _builder.Use<MvcMiddleware>();
        
        // Добавляю всю коллекцию сервисов в IOC контейнер 
        Container = collection.BuildServiceProvider();
    }
    
    public void Start()
    {
        // Определяю ссылку для прослушивания и начинаю слушать 
        _listener.Prefixes.Add($"http://localhost:{_port}/");
        _listener.Start();
        
        Console.WriteLine($"Server started on port: {_port}");

        // Вызываю метод для конфигурации сервисов 
        ConfigureServices(); 
        
        while (true)
        {
            // Беру результат прослушивания
            HttpListenerContext? context = _listener.GetContext();

            if (context != null)
            {
                HandleRequest(context);
            }
        }
    }

    public void HandleRequest(HttpListenerContext context)
    {
        // Собирает все middleware
        HttpHandler handler = _builder.Build();
        
        // Запускает цепочку обработки запроса от стороны пользователя 
        handler.Invoke(context);
    }
    
    #region OldHandleRequest

    /*

    public void HandleRequest(HttpListenerContext context)
    {
        var parts = context.Request.RawUrl.Split('/', StringSplitOptions.RemoveEmptyEntries);
        
        var assembly = Assembly.GetExecutingAssembly();

        var endpoints = assembly.GetTypes().Where(x => typeof(IEndpoint).IsAssignableFrom(x));

        string? endpointName = null;
        foreach (var item in endpoints)
        {
            if (parts[0] == item.Name)
            {
                endpointName = item.Name;
                break;
            }
        }

        if (endpointName == null)
            throw new Exception("Path is wrong");

        var endpointType = assembly.GetType($"WebServer.Services.Classes.Endpoints.{endpointName}");
        
        var method = endpointType.GetMethod(parts[1]);

        var obj = Activator.CreateInstance(endpointType) as Car;
        var res = method?.Invoke(obj, null) as List<Automobile>;

        var bytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(res, Formatting.Indented));
        
        context.Response.ContentType = "application/json";

        context.Response.OutputStream.Write(bytes, 0, bytes.Length);
        
        context.Response.Close();
    }
    */
    #endregion
}