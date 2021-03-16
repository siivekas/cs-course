using System;
using System.Globalization;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double rootThree = Math.Sqrt(3);
            
            Console.WriteLine("Enter h:");
            double h = double.Parse(
                Console.ReadLine().Replace(",", "."),
                CultureInfo.InvariantCulture
                );
            
            Console.WriteLine("Enter a:");
            double a = double.Parse(
                Console.ReadLine().Replace(",", "."),
                CultureInfo.InvariantCulture
                );

            var Sside = 3 * a * h;
            var Sfull = 1.5 * a * (a * rootThree + 2 * h);
            var H = Math.Sqrt(Math.Pow(h, 2) - Math.Pow(a, 2) / 12);
            var V = Math.Pow(a, 2) * H * rootThree / 2;
            
            Console.WriteLine($"S side = {Sside}");
            Console.WriteLine($"S full = {Sfull}");
            Console.WriteLine($"V = {V}");
        }
    }
}
