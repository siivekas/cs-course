using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст");

            string rawAge = Console.ReadLine();
            if (!int.TryParse(rawAge, out int age))
            {
                Console.WriteLine("Это не возраст");
                return;
            }

            string label;
            int lastChar = int.Parse(rawAge.Substring(rawAge.Length - 1));

            if ((age >= 10 && age <= 19) || lastChar >= 5 || lastChar == 0)
            {
                label = "лет";
            } else if (lastChar >= 2)
            {
                label = "года";
            } else
            {
                label = "год";
            }
            
            Console.WriteLine($"{age} {label}");
        }
    }
}