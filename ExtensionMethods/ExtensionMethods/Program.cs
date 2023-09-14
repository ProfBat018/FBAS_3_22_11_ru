// string name = "Elvin";
//
// name.Foo(); // syntax sugar 
// StringExtensions.Foo(name);
//
// static class StringExtensions {
//     public static void Foo(this string data)
//     {
//         Console.WriteLine($"Aloha: {data}");
//     }
// }

List<int> nums = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// LINQ Method
// nums.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));

var res = nums.Where(x => x % 2 == 0);

List<int> evenNums = new(res);
Stack<int> evenNumsStack = new(res);
Queue<int> evenNumsQueue = new(res);




