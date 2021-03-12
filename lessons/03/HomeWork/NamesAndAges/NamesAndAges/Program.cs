using System;
using System.Globalization;

namespace NamesAndAges
{
    class Program
    {
        static void Main(string[] args)
        {
            int namesCount;
            Console.WriteLine("Hi, I am HW-2021031! Enter, how many names I have to process:");
            if (!int.TryParse(Console.ReadLine(), out namesCount))
            {
                Console.WriteLine("Cannot parse into integer. Press any key to exit.");
                Console.ReadKey();
                return;
            }

            string[] names = new string[namesCount];
            for (int i = 0; i < namesCount; i++)
            {
                string message = (i == namesCount-1) ? "Enter the last name:" : "Enter name:";
                Console.WriteLine(message);
                names[i] = Console.ReadLine();
            }

            int[] ages = new int[namesCount];
            for (int i = 0; i < namesCount; i++)
            {
                Console.WriteLine($"Enter {names[i]}`s age:");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    ages[i] = age;
                }
                else
                {
                    Console.WriteLine("Cannot parse into integer. Press any key to exit.");
                    Console.ReadKey();
                    return;
                }
            }

            for (int i = 0; i < namesCount; i++)
            {
                Console.WriteLine($"In 4 years {names[i]} will be {ages[i] + 4} years old");
            }
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}