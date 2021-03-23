using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Enter string 15 or less symbols long");
            do
            {
                userInput = Console.ReadLine();
                if (userInput.Length > 15)
                {
                    Console.WriteLine("Too long string, try once more");
                    continue;
                }
                Console.WriteLine($"Entered string length is {userInput.Length}");
            } while (userInput != "exit");
        }
    }
}