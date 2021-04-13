using System;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDocument[] docs =
            {
                new BaseDocument("Document",
                    "#bebebe",
                    new DateTimeOffset(2000, 12, 12, 14, 55, 00, TimeSpan.Zero)),
                new Passport("#faefd",
                    new DateTimeOffset(2003, 6, 17, 12, 00, 00, TimeSpan.Zero),
                    "Russian Federation",
                    "Ivan Ivanov")
            };

            foreach (BaseDocument doc in docs)
            {
                if (doc is Passport pass) pass.ChangeIssueDate(new DateTimeOffset(DateTime.Now));
                doc.WriteToConsole();
            }

            Console.ReadKey();
        }
    }
}