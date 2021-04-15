using System;

namespace Reminder
{
    public class ReminderItem
    {
        private DateTimeOffset _alarmDate;
        private string _alarmMessage;

        public DateTimeOffset AlarmDate
        {
            get => _alarmDate;
            set => _alarmDate = value;
        }

        public string AlarmMessage
        {
            get => _alarmMessage;
            set
            {
                if (value is null) throw new ArgumentNullException();
                _alarmMessage = value;
            }
        }

        public TimeSpan TimeToAlarm => AlarmDate - DateTimeOffset.Now;
        public bool IsOutdated => TimeToAlarm <= TimeSpan.Zero;

        public ReminderItem(DateTimeOffset alarmDate, string alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }

        public void WriteProperties() => Console.WriteLine($"Alarm date: {AlarmDate:g}\n" +
                                                           $"Alarm message: {AlarmMessage}\n" +
                                                           $"Time to alarm: {TimeToAlarm:dd\\.hh\\:mm\\:ss}\n" +
                                                           $"Is outdated: {IsOutdated}\n");
    }
}