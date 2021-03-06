using System;
using System.Threading;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            var marks = new[]
            {
                new[] {2, 3, 3, 3},
                new[] {5, 2, 3},
                null,
                new[] {5, 5, 5, 5},
                new[] {4}
            };

            double weekSum = 0.0;
            int marksNum = 0;
            for (int weekDay = 0; weekDay < marks.Length; weekDay++)
            {
                double daySum = 0.0;
                if (marks[weekDay] is null)
                {
                    Console.WriteLine($"The average mark for day #{weekDay + 1}: N/A");
                    continue;
                }

                foreach (int mark in marks[weekDay])
                {
                    marksNum++;
                    daySum += mark;
                }

                weekSum += daySum;
                Console.WriteLine(
                    $"The average mark for day #{weekDay + 1}: {Math.Round(daySum / marks[weekDay].Length, 1)}");
            }

            Console.WriteLine(
                $"The average mark for whole week: {Math.Round(weekSum / marksNum, 1)}");

            FinishProcess();
        }

        static void FinishProcess(int milliseconds = 0)
        {
            Thread.Sleep(milliseconds);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}