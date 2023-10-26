using BookCenter.Services.Interfaces;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookCenter.Services.Classes;

class JsonService : IJsonService
{
    private readonly IDownloadService _service;
    public JsonService(IDownloadService service)
    {
        _service = service;
    }

    public T Deserialize<T>(string json)
    {
        return JsonSerializer.Deserialize<T>(json) ?? throw new NullReferenceException("Data is null");
    }
}
