#region Part1

// using System.Text;

// string text = "Иса джан, салам алейкум!";
//
// var fs = new FileStream("data.txt", FileMode.OpenOrCreate);
//
// byte[] buffer = Encoding.UTF8.GetBytes(text);
//
// fs.Write(buffer, 0, buffer.Length);
//
// fs.Close();

#endregion

#region Part2

// using System.Text;

// string text = "Иса джан, салам алейкум!";

// var fs = new FileStream("data.txt", FileMode.OpenOrCreate);
// var sw = new StreamWriter(fs);

// sw.WriteLine(text);

// sw.Close();
// fs.Close();

#endregion

#region Part3

// string text = "Иса джан, салам алейкум!";
//
// using (var fs = new FileStream("data.txt", FileMode.OpenOrCreate))
// {
//     using (var sw = new StreamWriter(fs))
//     {
//         sw.WriteLine(text);
//     }
// }

#endregion

#region Part4

// string text = "Иса джан, салам алейкум!";
//
// using var fs = new FileStream("data.txt", FileMode.OpenOrCreate);
// using var sw = new StreamWriter(fs);
//
// sw.WriteLine(text);

#endregion

#region Generics

// using System.Collections;

// ArrayList list = new() {1, "2", true, 4.4m};

// int num1 = (int)list[0];
// int num2 = list[0] as int;


// List<int> list = new() {1, 2, 3, 4, 5};
// List<object> list2 = new() { 1, "2", true, 4.4m };

// public delegate T2 MyDelegate<in T, out T2>(T2 arg);
// Func<int, int, float> a;

#endregion

#region LINQ

// Language Integrated Query

// var name = "Elvin Azimov";
// var list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};


// var res1 = list.Where(x => x % 2 == 0);
// var res2 = name.Where(x => x == 'E');


// text.Isa();
// StringExtensions.Isa(text);

// static class StringExtensions
// {
// public static void Isa(this string text)
// {
// Console.WriteLine(text);
// }
// }

#endregion

#region Exceptions
/*
using System.Net;

try
{
    var res = foo();
}
catch (Exception ex) when(ex.Message.Contains("Null"))
{
    Console.WriteLine(ex.Message);
}


string foo()
{
    using WebClient client = new();

    try
    {
        string? data = client.DownloadString("https://jsonplaceholdertypicode.com/users");

        return data ?? throw new Exception("Data is null");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        throw;
    }
}

Console.WriteLine("End of the program");
*/
#endregion

#region Reflection
/*
using System.Reflection;

// string name = "Elvin";

// var type1 = typeof(string); // Type. берем тип у типа данных
// var type2 = name.GetType(); // Type. берем тип у объекта(переменной)
// var assembly = Assembly.GetExecutingAssembly(); // Assembly. берем сборку


A? aObj = new();

string? res = aObj.GetType()?.GetMethod("ToString").Invoke(aObj, null) as string;


Console.WriteLine(res);

// object a = 5;
// int? b = a as int;

class A
{
    public override string ToString()
    {
        return $"This is my Tostring";
    }
}


*/

#endregion

#region DefaultInterfaces

// var a = 5;


#endregion


// object a = 5;

using System.Text;

string a;
StringBuilder b;

