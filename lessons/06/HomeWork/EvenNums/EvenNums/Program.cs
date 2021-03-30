using System;

namespace EvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter some positive integer or \"exit\" to exit process");
                try
                {
                    string userInput = Console.ReadLine();
                    
                    if(userInput == "exit") break;
                    
                    if(int.Parse(userInput) <= 0) throw new ArgumentException();
                    
                    int evenNum = 0;
                    for (int i = 0; i < userInput.Length; i++)
                    {
                        if (userInput[i] % 2 == 0) evenNum++;
                    }
                    
                    Console.WriteLine($"In number {userInput} there is {evenNum} even number(s)");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Non numeric input");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Too long number");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Negative or zero number");
                }
            }
        }
    }
}