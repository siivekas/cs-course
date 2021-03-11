using System;
using System.Threading;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dynamicVar = "string";
            dynamicVar = 5;
            Console.WriteLine(Math.Pow(dynamicVar, 2));
            
            object objString = "string";
            Console.WriteLine(objString.ToString().Length);
            
            var doubleVar = 5.5;
            Console.WriteLine(doubleVar.GetType());
            
            char a = default(char);
            Console.WriteLine(a);

            var array = new string[4];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("---");
            Thread.Sleep(1000);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}