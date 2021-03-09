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
            // проверяем и кастуем в дабл ввод юзера
            if (double.TryParse(
                Console.ReadLine().Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator),
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out number1
            ))
            {
                Console.WriteLine("Enter one more number:");
                double number2;
                // проверяем и кастуем в дабл второй ввод юзера
                if (double.TryParse(
                    Console.ReadLine().Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator),
                    NumberStyles.Float,
                    CultureInfo.InvariantCulture,
                    out number2
                ))
                {
                    // красиво выводим меню
                    string[] phrases =
                    {
                        "Choose operation type:",
                        "0 - addition (+)",
                        "1 - subtraction (-)",
                        "2 - multiplication (*)",
                        "3 - division (/)",
                        "4 - exponentiation (^)"
                    };
                    foreach (string phrase in phrases)
                    {
                        Console.WriteLine(phrase);
                    }
                    // проверяем и кастуем в инт выбор юзера
                    int operationType;
                    if (
                        int.TryParse(Console.ReadLine(), out operationType) &&
                        operationType >= 0 &&
                        operationType <= 4
                    )
                    {
                        // выводим результат
                        switch (operationType)
                        {
                            case 0: Console.WriteLine($"Sum equals to {number1 + number2}");
                                break;
                            case 1: Console.WriteLine($"Difference equals to {number1 - number2}");
                                break;
                            case 2: Console.WriteLine($"Composition equals to {number1 * number2}");
                                break;
                            case 3: Console.WriteLine($"Quotient equals to {number1 / number2}");
                                break;
                            case 4: Console.WriteLine($"{number1} raised to the power of {number2} equals to {Math.Pow(number1, number2)}");
                                break;
                        }
                        
                        // подтверждение завершения операции
                        Console.WriteLine("Press eny key to finish process");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Choose valid operation type");
                    }
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