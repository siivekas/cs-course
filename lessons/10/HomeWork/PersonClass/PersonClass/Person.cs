using System;

namespace PersonClass
{
    public class Person
    {
        private string _mName;
        private int _mAgeYears;

        public string Name
        {
            get { return _mName; }
            set { _mName = value[0].ToString().ToUpper() + value.Substring(1); }
        }

        public int AgeYears
        {
            get { return _mAgeYears; }
            set
            {
                if (value >= 0) _mAgeYears = value;
                else throw new ArgumentOutOfRangeException(); // можно возвращать модуль, но я хочу попробовать так
            }
        }

        public int AgeIn4
        {
            get { return AgeYears + 4; }
        }

        public string Description
        {
            get { return $"Имя: {Name}, полных лет: {AgeYears}, через 4 года: {AgeIn4}"; }
        }
        
        public static string InputPersonName(int number = 0)
        {
            Console.WriteLine($"Введите имя пользователя {number + 1}:");
            string userInputName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userInputName))
                throw new ArgumentNullException();

            return userInputName;
        }

        public static int InputPersonAge(int number = 0)
        {
            int userAge;
            Console.WriteLine($"Введите возраст пользователя {number + 1}:");
            string userInputAge = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userInputAge)) throw new ArgumentNullException();

            userAge = int.Parse(userInputAge);
            if (userAge < 0) throw new ArgumentOutOfRangeException();

            return userAge;
        }
    }
}