using System;
using System.Linq;

namespace NormalizeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string:");

            while (true)
            {
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Empty string, try again");
                    continue;
                }
                
                Console.WriteLine(userInput.ToLower().Reverse().ToArray());
                break;
            }
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}