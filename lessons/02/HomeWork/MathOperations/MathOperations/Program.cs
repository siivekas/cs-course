using System;
using System.Globalization;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            double number1;
            double number2;
            if (double.TryParse(
                Console.ReadLine().Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator),
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out number1
            ))
            {
                Console.WriteLine("Enter one more number:");
                if (double.TryParse(
                    Console.ReadLine().Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator),
                    NumberStyles.Float,
                    CultureInfo.InvariantCulture,
                    out number2
                ))
                {
                    Console.WriteLine($"number1 + number2 = {number1 + number2}");
                    Console.WriteLine($"number1 - number2 = {number1 - number2}");
                    Console.WriteLine($"number1 * number2 = {number1 * number2}");
                    Console.WriteLine($"number1 / number2 = {number1 / number2}");
                }
                else
                {
                    Console.WriteLine("Do not enter letters, only numbers!");
                }
            }
            else
            {
                Console.WriteLine("Do not enter letters, only numbers!");
            }
        }
    }
}