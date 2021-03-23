using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = {1, 2, 3, 4, 5, 6, 7};
            int i= 0;
            int sum = 0;
            while (i < ar.Length)
            {
                sum += ar[i];
                Console.WriteLine($"Now sum is {sum}");
                i++;
            }
        }
    }
}