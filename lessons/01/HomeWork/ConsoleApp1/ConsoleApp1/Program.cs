using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name and press Enter button:");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine($"Hi, {name}!");
            Thread.Sleep(5000);
            Console.WriteLine($"Good bye, {name}. Press any key to finish process.");
            
            Console.ReadKey();
        }
    }
}