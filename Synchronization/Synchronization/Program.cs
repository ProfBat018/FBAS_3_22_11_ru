namespace Synchronization;

#region WithoutMutex
/*
class Program
{
    public static void CountToTen()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"This is {i} from thread {Thread.CurrentThread.ManagedThreadId}");
        }
    }

    public static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Creating thread");
            Thread th = new(CountToTen);
            Console.WriteLine("Starting thread");
            th.Start();
        }
    }
}
*/
#endregion

#region WithMutex

class Program
{
    public static void CountToTen()
    {
        // Первый параметер это принадлежит ли он кому-то по умолчанию, а второй это его название
        using Mutex mutex = new(false, "MutexExample");

        mutex.WaitOne();
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"This is {i} from thread {Thread.CurrentThread.ManagedThreadId}");
        }
        mutex.ReleaseMutex();
    }

    public static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Creating thread");
            Thread th = new(CountToTen);
            Console.WriteLine("Starting thread");
            th.Start();
        }
    }
}

#endregion