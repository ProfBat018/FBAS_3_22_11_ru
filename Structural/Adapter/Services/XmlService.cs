using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Adapter.Models;

namespace Adapter.Services;

class XmlService : ISerializeService
{
    public static T Deserialize<T>(string path) where T : ICurrency
    {
        XmlSerializer serializer = new(typeof(T));

        using var reader = new StringReader(path);

        return (T)serializer.Deserialize(reader);
    }

    public static string Serialize<T>(T data) where T : ICurrency
    {
        XmlSerializer serializer = new(typeof(T));

        using var writer = new StringWriter();

        serializer.Serialize(writer, data);

        return writer.ToString();
    }
}
