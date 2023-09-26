// A a = new A();
// Console.WriteLine(a.a);
// Console.WriteLine(a.b);
//
// Thread.Sleep(10000);
//
//
// class A
// {
//     public struct B
//     {
//         public int c;
//     }
//     
//     public int a = 5;
//     public int b { get; set; } = 10;
//     public B Bobj { get; set; } = new();
//     public string Name { get; set; } = "Elvin";
// }
//

// using Crypto = BCrypt.Net.BCrypt;

// Crypto.HashPassword("123456");



// A aObj = new();
// A aObj2 = new();
//
// A.op_GreaterThan(aObj, aObj2);
//
// class A
// {
//     public int a;
//     
//     public static bool op_GreaterThan(A a, A b)
//     {
//         return a.a > b.a;
//     }
// }


string text = "Hello Eldaniz!";

using (FileStream fs = new("data.txt", FileMode.OpenOrCreate))
{
    using (StreamWriter sw = new(fs))
    {
        sw.WriteLine(text);
    }
}






