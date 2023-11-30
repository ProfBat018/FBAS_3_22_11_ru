using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Models;

namespace Adapter.Services;

class XmlToJsonAdapter
{
    public string ConvertXmlToJson<T>(string xml) where T : ICurrency
    {
        var data = XmlService.Deserialize<T>(xml);    
        var json = JsonService.Serialize<T>(data);
        return json;
    }

}
