using System;

namespace ColorPicker
{
    class Program
    {
        private const int SelectedNum = 4;
        private const int TryNum = 2;
        
        static void Main(string[] args)
        {
            Colors notSelected = default;
            Colors selected = default;
            Console.WriteLine($"Choose {SelectedNum} colors:");
            foreach (Colors color in Enum.GetValues(typeof(Colors)))
            {
                notSelected = notSelected | color;
                Console.WriteLine($"{(int)color} - {color}");
            }

            for (int i = 0; i < SelectedNum; i++)
            {
                Console.WriteLine($"Color №{i+1}:");
                for (int triesLeft = TryNum; triesLeft > 0; triesLeft--)
                {
                    if (Enum.TryParse(Console.ReadLine(), out Colors userInput) &&
                        Enum.IsDefined(typeof(Colors), userInput))
                    {
                        selected = selected | userInput;
                        notSelected = notSelected ^ userInput;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input, try again (color №{i+1}, tries left: {triesLeft-1})");
                    }
                }
            }
            Console.WriteLine($"Selected colors: {selected}");
            Console.WriteLine($"Not selected colors: {notSelected}");
        }
    }
}
