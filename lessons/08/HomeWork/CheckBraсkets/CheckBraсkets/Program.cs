using System;
using System.Collections.Generic;

namespace CheckBraсkets
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите строку для проверки скобок или \"exit\" для выхода:");
                string userInput = Console.ReadLine();
                if(string.Equals(userInput, "exit", StringComparison.OrdinalIgnoreCase)) break;

                try
                {
                    bool check = CheckBrackets(userInput);
                    switch (check)
                    {
                        case true:
                            Console.WriteLine("Скобки расставлены.");
                            break;
                        case false:
                            Console.WriteLine("Ошибка в расстановке скобок.");
                            break;
                    }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Введен null.");
                }
            }
        }

        /// <summary>
        /// Проверяет строку на баланс скобок и кавычек
        /// </summary>
        /// <param name="inputStr">Входная строка</param>
        /// <returns>bool</returns>
        /// <exception cref="ArgumentNullException">Если на вход передан null</exception>
        private static bool CheckBrackets(string inputStr)
        {
            // маппинг скобок
            var bracketsMap = new Dictionary<char, char>
            {
                {')', '('},
                {']', '['},
                {'}', '{'},
                {'>', '<'},
                {'"', '"'},
                {'\'', '\''}
            };
            var bracketsTmp = new Stack<char>();

            if (inputStr is null) throw new ArgumentNullException();
            if (inputStr.Length == 0) return true; // нет символов - нет скобок - нет ошибок
            
            // проверка соответствия
            foreach (var item in inputStr)
            {
                // открывающую скобку закинуть в стек
                if (bracketsMap.ContainsValue(item)) bracketsTmp.Push(item);
                // закрывающую скобку проверить на соответствие открывающей
                if (bracketsMap.ContainsKey(item))
                {
                    if (bracketsTmp.Count == 0) return false; // в пустом стеке соответствия точно нет
                    if (bracketsTmp.Pop() != bracketsMap[item]) return false;
                }
            }

            return bracketsTmp.Count == 0; // если в стеке что-то осталось, то тоже ошибка
        }
    }
}