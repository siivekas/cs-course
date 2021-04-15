using System;

namespace Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            var ri1 = new ReminderItem(
                DateTimeOffset.Now.AddDays(-3),
                "Alarm 1"
            );
            var ri2 = new ReminderItem(
                DateTimeOffset.Now.AddDays(+2),
                "Alarm 2"
            );
            
            ri1.WriteProperties();
            ri2.WriteProperties();
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}