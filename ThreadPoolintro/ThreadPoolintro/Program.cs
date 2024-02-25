
class Program
{
    public static void ThreadPoolExample()
    {
        Console.WriteLine($"Thread count: {ThreadPool.ThreadCount}");
        Console.WriteLine($"Pending Thread count: {ThreadPool.PendingWorkItemCount}");
        Console.WriteLine($"Completed Thread count: {ThreadPool.CompletedWorkItemCount}");
    }

    public static void Main()
    {
        using var countDownEvent = new CountdownEvent(3);

        var mutex = new Mutex();

        for (int i = 0; i < countDownEvent.InitialCount; i++)
        {
            ThreadPool.QueueUserWorkItem(
            (p) =>
            {
                mutex.WaitOne();
                Console.WriteLine($"Is ThreadPool Thread {Thread.CurrentThread.IsThreadPoolThread}");
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");

                countDownEvent.Signal();

                mutex.ReleaseMutex();
            });
        }
        countDownEvent.Wait();

        Console.WriteLine("End of main");
    }
}
