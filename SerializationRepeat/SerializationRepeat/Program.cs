#region NeedOfSerialization

/*
List<User> users = new()
{
    new User { Name = "John", Age = 25 },
    new User { Name = "Jane", Age = 30 },
    new User { Name = "Jack", Age = 35 }
};

using FileStream fs = new("users.txt", FileMode.OpenOrCreate);
using StreamWriter sw = new(fs);

foreach (User user in users)
{
    sw.WriteLine(user);
}
*/
//
// using FileStream fs = new("users.txt", FileMode.OpenOrCreate);
// using StreamReader sr = new(fs);
//
// var res = sr.ReadToEnd();
//
// Console.WriteLine(res);
//
// class User
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
//
//     public override string ToString()
//     {
//         return $"Name: {Name}, Age: {Age}";
//     }
// }

#endregion

#region BinarySerialization
/*
using System.Runtime.Serialization.Formatters.Binary;

List<User> users = new()
{
     new User { Name = "John", Surname = "Doe" },
     new User { Name = "Jane", Surname = "Doe" },
     new User { Name = "Jack", Surname = "Doe" }
};

using FileStream fs = new("users.bin", FileMode.OpenOrCreate);

#pragma warning disable SYSLIB0011 
BinaryFormatter formatter = new();

formatter.Serialize(fs, users);
*/
#endregion
#region BinaryDeserialization

// using System.Runtime.Serialization.Formatters.Binary;

// #pragma warning disable SYSLIB0011

// using FileStream fs = new("users.bin", FileMode.OpenOrCreate);
// BinaryFormatter formatter = new();
//
// List<User>? users = formatter.Deserialize(fs) as List<User>;
//
// if (users != null)
// {
//      foreach (User user in users)
//      {
//          Console.WriteLine($"Name: {user.Name}, Surname: {user.Surname}");
//      }
// }

#endregion


#region XMLSerialization

// using System.Net;
// using System.Text;
// using System.Xml;
// using System.Xml.Serialization;
// using SerializationRepeat;
//
// WebClient client = new();
// string xmlRes = client.DownloadString("https://www.cbar.az/currencies/22.09.2023.xml");
//
// XmlSerializer serializer = new(typeof(ValCurs));
//
// using StringReader stringReader = new(xmlRes);
// using XmlTextReader xmlReader = new(stringReader);
//
// var res = serializer.Deserialize(xmlReader) as ValCurs;
//
// Console.WriteLine(res?.ValType[0].Valute[0].Name);
// Console.WriteLine(res?.ValType[0].Valute[0].Value);


#endregion
#region JsonSerialization

// using System.Text.Json;

// User[] users = new[]
// {
    // new User { Name = "John", Surname = "Doe" },
    // new User { Name = "Jane", Surname = "Doe" },
    // new User { Name = "Jack", Surname = "Doe" }
// };

// string json = JsonSerializer.Serialize(users);

// using FileStream fs = new("users.json", FileMode.OpenOrCreate);
// using StreamWriter sw = new(fs);

// sw.Write(json);

#endregion
#region JsonDeserialization
/*
using System.Net;
using System.Text.Json;
using SerializationRepeat;

string url =
    @"https://api.openweathermap.org/data/2.5/weather?q=baku&appid=2b1fd2d7f77ccf1b7de9b441571b39b8&units=metric";

WebClient client = new();

string jsonRes = client.DownloadString(url);

Forecast? res = JsonSerializer.Deserialize<Forecast>(jsonRes);

Console.WriteLine(res?.main.temp);
*/
#endregion

namespace Finalizer
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public Car()
        {
            Console.WriteLine("Car constructor");
        }

        ~Car()
        {
            Console.WriteLine("Car finalizer");
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Car c1 = new Car();
            GC.Collect();

            Console.WriteLine("Done");
        }
    }
}