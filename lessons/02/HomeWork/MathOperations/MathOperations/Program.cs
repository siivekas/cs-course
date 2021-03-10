using System;
using System.Globalization;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            if (!TryReadDouble(out double number1))
            {
                ShowError("Do not enter letters, only numbers!");
                return;
            }

            Console.WriteLine("Enter one more number:");
            if (!TryReadDouble(out double number2))
            {
                ShowError("Do not enter letters, only numbers!");
                return;
            }

            string[] phrases =
            {
                "Choose operation type:",
                "0 - addition (+)",
                "1 - subtraction (-)",
                "2 - multiplication (*)",
                "3 - division (/)",
                "4 - remainder of division (%)",
                "5 - exponentiation (^)"
            };
            foreach (string phrase in phrases)
            {
                Console.WriteLine(phrase);
            }

            if (!int.TryParse(Console.ReadLine(), out int operationType))
            {
                ShowError("Do not enter letters, only numbers!");
                return;
            }

            switch (operationType)
            {
                case 0:
                    Console.WriteLine($"Sum equals to {number1 + number2}");
                    break;
                case 1:
                    Console.WriteLine($"Difference equals to {number1 - number2}");
                    break;
                case 2:
                    Console.WriteLine($"Composition equals to {number1 * number2}");
                    break;
                case 3:
                    string message = (number2 == 0)
                        ? "Can`t divide by zero "
                        : $"Quotient equals to {number1 / number2}";
                    Console.WriteLine(message);
                    break;
                case 4:
                    Console.WriteLine($"Remainder of division equals to {number1 % number2}");
                    break;
                case 5:
                    Console.WriteLine(
                        $"{number1} raised to the power of {number2} equals to {Math.Pow(number1, number2)}");
                    break;
                default:
                    Console.WriteLine("Undefined operation type");
                    break;
            }

            Console.WriteLine("Press any key to finish process");
            Console.ReadKey();
        }

        static bool TryReadDouble(out double number)
        {
            return double.TryParse(
                Console.ReadLine().Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator),
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out number
            );
        }

        static void ShowError(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Press any key to finish process");
            Console.ReadKey();
        }
    }
}