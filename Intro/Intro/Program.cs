using System.Diagnostics;

#region Part1

// class Program
// {
//     public static void Test()
//     {
//         
//         ThreadStart action1 = () =>
//         {
//             Console.WriteLine("I created this action and this Thread");
//             Console.WriteLine($"My working thread in function Test is: {Thread.CurrentThread.ManagedThreadId}");
//         };
//
//         Thread th1 = new(action1);
//
//         th1.Start();
//
//     }
//     public static void Main()
//     {
//         Console.WriteLine("Main Thread");
//         Console.WriteLine($"My working thread is: {Thread.CurrentThread.ManagedThreadId}");
//         Test();
//         Console.WriteLine($"My working thread is: {Thread.CurrentThread.ManagedThreadId}");
//     }
// }


// var allThreads = Process.GetCurrentProcess().Threads;
//
//
// foreach (ProcessThread item in allThreads)
// {
//     Console.WriteLine($"{item.Id} {item.ThreadState}");
// }

#endregion


#region Part2

class Program
{
        public static void Func1()
        {
            Console.WriteLine("Aloha");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }

        public static void Func2(int a)
        {
            Console.WriteLine($"Aloha: {a}");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        }
    public static void Main(string[] args)
    {
        Thread th1 = new(new ThreadStart(() =>
        {
            Func1();
        }));
        
        Thread th2 = new(new ParameterizedThreadStart((a) =>
        {
            Func2((int)a);
        }));
        
        th1.Start();
        th2.Start(5);
    }
}

#endregion
