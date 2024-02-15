#region Part1

/*
class Program
{
    public static void Example()
    {
        Thread th1 = new(() =>
        {
            Console.WriteLine($"Aloha from {Thread.CurrentThread.ManagedThreadId}");
        });

        th1.Start();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Main started");
        Console.WriteLine($"Aloha from {Thread.CurrentThread.ManagedThreadId}");
        Example();
        Console.WriteLine($"Aloha from {Thread.CurrentThread.ManagedThreadId}");
        Console.WriteLine("Main finished");
    }
}
*/

#endregion

#region WithLock


class Program
{
    static object locker = new object();

    static void Main()
    {
        var th1 = new Thread(Count);
        th1.Start();
        Count();
    }

    static void Count()
    {
        lock (locker)
        {
            Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
    }
}


#endregion

#region WithoutLock
/*
class Program
{
    static void Main()
    {
        var th1 = new Thread(Count);
        th1.Start();
        Count();
    }

    static void Count()
    {
        Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId}");
        for (int i = 1; i < 9; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(100);
        }
    }
}
*/
#endregion