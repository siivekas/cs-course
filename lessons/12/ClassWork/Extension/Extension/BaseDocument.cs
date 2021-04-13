using System;

namespace Extension
{
    public class BaseDocument
    {
        public string Title { get; set; }
        public string Number { get; set; }
        public DateTimeOffset IssueDate { get; set; }

        public BaseDocument(string title, string number, DateTimeOffset issueDate)
        {
            Title = title;
            Number = number;
            IssueDate = issueDate;
        }

        public virtual string Description => $"Type {GetType()} \n" +
                                             $"Title {Title} \n" +
                                             $"Number {Number} \n" +
                                             $"Issue date {IssueDate} \n";

        public void WriteToConsole() => Console.WriteLine(Description);
    }
}