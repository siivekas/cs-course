using System;

namespace HowManyA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку из как минимум двух слов:");

            int count = 0;
            while (true)
            {
                string[] userInputArray = Console.ReadLine().ToLower().Split(new[] {' ', '\t'},
                    StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                if (userInputArray.Length < 2)
                {
                    Console.WriteLine("Слишком мало слов, попробуйте еще раз.");
                    continue;
                }

                foreach (string str in userInputArray)
                    if (str[0].ToString().Equals("а", StringComparison.OrdinalIgnoreCase))
                        count++;
                break;
            }

            Console.WriteLine($"Слов, начинающихся с буквы \"а\" (кириллица): {count}");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}