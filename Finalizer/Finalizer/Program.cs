using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Finalizer
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public Car()
        {
            Console.WriteLine("Car constructor");
        }

        ~Car()
        {
            Console.WriteLine("Car finalizer");
            Thread.Sleep(1000);
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Car c1 = new Car();
            GC.Collect();

            Console.WriteLine("Done");
        }
    }
}