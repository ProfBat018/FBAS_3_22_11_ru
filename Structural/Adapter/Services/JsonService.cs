using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Models;
using Newtonsoft.Json;

namespace Adapter.Services;
class JsonService : ISerializeService
{
    public static T Deserialize<T>(string path) where T : ICurrency
    {
        return JsonConvert.DeserializeObject<T>(path);
    }

    public static string Serialize<T>(T data) where T : ICurrency
    {
        return JsonConvert.SerializeObject(data, Formatting.Indented);
    }
}
