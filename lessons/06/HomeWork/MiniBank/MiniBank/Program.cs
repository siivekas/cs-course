using System;
using System.Globalization;

namespace MiniBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите сумму первоначального взноса:");
                double initial = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
                if (initial <= 0)
                    throw new ArgumentException("Значение должно быть больше 0");
                
                Console.WriteLine("Введите ежеднедневный процент дохода в виде десятичной дроби (1% = 0.01):");
                double dailyPercent = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
                if (dailyPercent <= 0)
                    throw new ArgumentException("Значение должно быть больше 0");
                
                Console.WriteLine("Введите желаемую сумму накопления:");
                double result = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
                if (result <= 0)
                    throw new ArgumentException("Значение должно быть больше 0");

                if (initial >= result)
                    throw new ArgumentException("Результат достигнут");
                

                int daysTillResult = 0;
                while (initial < result)
                {
                    initial += (initial * dailyPercent);
                    daysTillResult++;
                }
                
                Console.WriteLine($"Дней до накопления желаемой суммы: {daysTillResult}");
                
                Console.WriteLine("Нажмите любую клавишу для выхода");
                Console.ReadKey();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Введен null");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено неверное значение");
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }
    }
}