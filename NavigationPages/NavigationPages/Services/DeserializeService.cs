using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NavigationPages.Services
{
    internal class DeserializeService
    {
        public static T Deserialize<T>(string json)
        {
            try
            {
                return JsonSerializer.Deserialize<T>(json) ?? throw new NullReferenceException();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
