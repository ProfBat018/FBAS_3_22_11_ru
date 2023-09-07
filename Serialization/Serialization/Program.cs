using System.IO.IsolatedStorage;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;
using Serialization;

List<Person> people = new()
{
    new("Elvis", "Presley"),
    new("Michael", "Jackson"),
    new("John", "Lennon"),
    new("Freddie", "Mercury"),
};

#region ProblemDescription

// using FileStream fs = new("people.txt", FileMode.OpenOrCreate);
// using StreamWriter sw = new(fs);

// foreach (Person person in people)
// {
    // sw.WriteLine(person);
// }




// using FileStream fs = new("people.txt", FileMode.OpenOrCreate);
// using StreamReader sr = new(fs);
//
// string res = sr.ReadToEnd();


#endregion

#region Serialization
#region BinarySerialization


// using FileStream fs = new("people.bin", FileMode.OpenOrCreate);
// BinaryFormatter formatter = new();
//
// #pragma warning disable SYSLIB0011 
// formatter.Serialize(fs, people);
// #pragma warning restore SYSLIB0011



#endregion

#region XMLSerialization

// XmlSerializer xmlSerializer = new(people.GetType());
 // using FileStream fs = new("data.xml", FileMode.OpenOrCreate);
 // XmlSerializer xmlSerializer = new(typeof(List<Person>));
 //
 // xmlSerializer.Serialize(fs, people);


#endregion

#region JSONSerialization

// using FileStream fs = new("data.json", FileMode.OpenOrCreate);
// using StreamWriter sw = new(fs);
//
// string json = JsonSerializer.Serialize(people);
// sw.WriteLine(json);

#endregion

#endregion


#region Deserialization

#region BinaryDeserialization    

/*
using FileStream fs = new("people.bin", FileMode.OpenOrCreate);
BinaryFormatter formatter = new();

#pragma warning disable SYSLIB0011
List<Person>? res = formatter.Deserialize(fs) as List<Person>;

res.Add(new("Isa", "Ismayilov"));

if (res is not null)
{
    foreach (Person person in res)
    {
        Console.WriteLine(person);
    }
}
#pragma warning restore SYSLIB0011
*/
#endregion

#region XMLDeserialization

// using FileStream fs = new("data.xml", FileMode.OpenOrCreate);
// XmlSerializer xmlSerializer = new(typeof(List<Person>));
//
// // Pattern matching
//
// if (xmlSerializer.Deserialize(fs) is List<Person> result)
// {
//     foreach (var person in result)
//     {
//         Console.WriteLine(person);
//     }
// }


#endregion


#region JSONDeserialization

using FileStream fs = new("data.json", FileMode.OpenOrCreate);
using StreamReader sr = new(fs);

string json = sr.ReadToEnd();

List<Person>? result = JsonSerializer.Deserialize<List<Person>>(json);

if (result is not null)
{
    foreach (var person in result)
    {
        Console.WriteLine(person);
    }
}

#endregion
#endregion


