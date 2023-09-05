

#region FirstMethod
/*
using System.Text;
string text = "Hello world!";
FileStream fs = new("data.txt", FileMode.OpenOrCreate);

byte[] buffer = Encoding.UTF8.GetBytes(text);

fs.Write(buffer);
fs.Close();
*/

#endregion

#region SecondMethod
/*
FileStream fs = new("data.txt", FileMode.OpenOrCreate);
StreamWriter sr = new(fs);

string text = "Hello world!";

sr.WriteLine(text);

sr.Close();
fs.Close();

*/
#endregion

#region ThirdMethod
// using of using statement

// string text = "Hello world!";
//
// using (FileStream fs = new("data.txt", FileMode.OpenOrCreate))
// {
//     using (StreamWriter sw = new(fs))
//     {
//         sw.WriteLine(text);
//     }
// }


#endregion

#region FourthMethod

// string text = "Hello world!";
// using FileStream fs = new("data.txt", FileMode.OpenOrCreate);
// using StreamWriter sw = new(fs);
// sw.WriteLine(text);

#endregion


