# Методы синхронизации потоков в C#

Проблема: 

Если вы используете несколько потоков в своем приложении, 
то вам нужно синхронизировать их, 
чтобы избежать состояния гонки.

Решение:

В C# есть несколько методов синхронизации потоков,
которые позволяют вам синхронизировать потоки.

1. lock
2. Mutex
3. Semaphore
4. SemaphoreSlim

Давайте начнем с `lock`

самое главное что вы должны понять, это то что 
`lock` это синтаксический сахар для `Monitor.Enter` и `Monitor.Exit`

пример использования `lock` с двумя потоками:

```csharp
using System;
using System.Threading;

class Program
{
    static object locker = new object();
    static void Main()
    {
        new Thread(Count).Start();
        Count();
    }

    static void Count()
    {
        lock (locker)
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
    }
}
```
