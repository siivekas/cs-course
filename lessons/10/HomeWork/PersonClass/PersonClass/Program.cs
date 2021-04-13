using System;
using System.Collections.Generic;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var personArray = new List<Person>(); // чтобы количество человек тоже сделать динамическим
            int personCount = GetPersonCount(); // чисто для красоты, чтобы обычный бесконечный цикл ошибок не занимал пол-экрана

            for (int i = 0; i < personCount; i++)
            {
                while (true)
                {
                    try
                    {
                        personArray.Add(new Person()
                        {
                            Name = Person.InputPersonName(i),
                            AgeYears = Person.InputPersonAge(i)
                        });
                        break;
                    }
                    catch (ArgumentNullException)
                    {
                        ShowColoredMessage("Ничего не введено, попробуйте еще раз.");
                    }
                    catch (FormatException)
                    {
                        ShowColoredMessage("Не могу распознать число, попробуйте еще раз.");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        ShowColoredMessage("Введено неположительное значение, попробуйте еще раз.");
                    }
                }
            }

            foreach (var person in personArray)
            {
                Console.WriteLine(person.Description);
                ShowColoredMessage(person.Description, ConsoleColor.Green);
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static int GetPersonCount()
        {
            int personCount;
            while (true)
            {
                try
                {
                    Console.WriteLine("Сколько человек добавить?");
                    string userInputCount = Console.ReadLine();
                    if (userInputCount is null)
                    {
                        ShowColoredMessage("Ничего не введено, попробуйте еще раз.");
                        continue;
                    }

                    personCount = int.Parse(userInputCount);
                    if (personCount <= 0)
                    {
                        ShowColoredMessage("Введено неположительное число, попробуйте еще раз.");
                        continue;
                    }

                    break;
                }
                catch (FormatException)
                {
                    ShowColoredMessage("Не могу распознать число, попробуйте еще раз.");
                }
            }

            return personCount;
        }

        static void ShowColoredMessage(string message, ConsoleColor color = ConsoleColor.Red)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}