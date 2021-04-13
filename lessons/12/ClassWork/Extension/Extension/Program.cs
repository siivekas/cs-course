using System;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDocument bd = new BaseDocument(
                "Document",
                "#bebebe",
                new DateTimeOffset(2000, 12, 12, 14, 55, 00, TimeSpan.Zero)
            );
            bd.WriteToConsole();

            Passport p = new Passport(
                "#faefd",
                new DateTimeOffset(2003, 6, 17, 12, 00, 00, TimeSpan.Zero)
            )
            {
                Country = "Russian Federation",
                PersonName = "Ivan Ivanov"
            };
            p.WriteToConsole();

            Console.ReadKey();
        }
    }
}