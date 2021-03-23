using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Enter some string. Entering \"exit\" will finish process.");
            do
            {
                userInput = Console.ReadLine();
            } while (userInput != "exit");
        }
    }
}