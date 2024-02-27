#region CountDownEvent
/*
class Program
{
    private static CountdownEvent countdownEvent = new(3);

    public static void Sample()
    {
        Mutex mutex = new();

        mutex.WaitOne();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"This is {i} from {Thread.CurrentThread.ManagedThreadId}");
        }

        countdownEvent.Signal();

        mutex.ReleaseMutex();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Main started...");
        for (int i = 0; i < 3; i++)
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Sample();
                Thread.Sleep(10);
            });
        }
        countdownEvent.Wait();
        Console.WriteLine("Main finished...");
    }
}
*/
#endregion

#region ManualResetEvent
/*
class Program
{
    private static ManualResetEvent _manualResetEvent = new(false);

    public static void Sample()
    {
        Mutex mutex = new();

        mutex.WaitOne();
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"This is {i} from {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(10);
        }

        mutex.ReleaseMutex();
        _manualResetEvent.Set();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Main started...");

        for (int i = 0; i < 3; i++)
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Sample();
            });
        }

        WaitHandle.WaitAll(new WaitHandle[] { _manualResetEvent });

        Console.WriteLine("Main finished...");
    }
}
*/
#endregion

#region AutoResetEvent

/*
class Program
{
    private static AutoResetEvent _autoResetEvent = new(false);

    public static void Sample()
    {
        Mutex mutex = new();

        mutex.WaitOne();
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"This is {i} from {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(10);
        }

        mutex.ReleaseMutex();
        _autoResetEvent.Set();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Main started...");

        for (int i = 0; i < 3; i++)
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Sample();
            });
        }

        _autoResetEvent.WaitOne();
        Console.WriteLine("Main finished...");
    }
}
*/
#endregion



