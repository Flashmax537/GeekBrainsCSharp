using System;

namespace lesson2Task6
{
    class Program
    {
        static void Main()
        {
            DaysOfWeek office1 = DaysOfWeek.Monday | DaysOfWeek.Tuesday | DaysOfWeek.Wednesday | DaysOfWeek.Thursday | DaysOfWeek.Friday;
            DaysOfWeek office2 = DaysOfWeek.Saturday | DaysOfWeek.Sunday;
            DaysOfWeek office3 = DaysOfWeek.Tuesday | DaysOfWeek.Thursday | DaysOfWeek.Saturday;

            Console.WriteLine("Режим работы офиса №1:" +
                $"\nПН - {isDay(office1, DaysOfWeek.Monday)}" +
                $"\nВТ - {isDay(office1, DaysOfWeek.Tuesday)}" +
                $"\nСР - {isDay(office1, DaysOfWeek.Wednesday)}" +
                $"\nЧТ - {isDay(office1, DaysOfWeek.Thursday)}" +
                $"\nПТ - {isDay(office1, DaysOfWeek.Friday)}" +
                $"\nСБ - {isDay(office1, DaysOfWeek.Saturday)}" +
                $"\nВС - {isDay(office1, DaysOfWeek.Sunday)}");

            Console.WriteLine("\nРежим работы офиса №2:" +
                $"\nПН - {isDay(office2, DaysOfWeek.Monday)}" +
                $"\nВТ - {isDay(office2, DaysOfWeek.Tuesday)}" +
                $"\nСР - {isDay(office2, DaysOfWeek.Wednesday)}" +
                $"\nЧТ - {isDay(office2, DaysOfWeek.Thursday)}" +
                $"\nПТ - {isDay(office2, DaysOfWeek.Friday)}" +
                $"\nСБ - {isDay(office2, DaysOfWeek.Saturday)}" +
                $"\nВС - {isDay(office2, DaysOfWeek.Sunday)}");

            Console.WriteLine("\nРежим работы офиса №3:" +
                $"\nПН - {isDay(office3, DaysOfWeek.Monday)}" +
                $"\nВТ - {isDay(office3, DaysOfWeek.Tuesday)}" +
                $"\nСР - {isDay(office3, DaysOfWeek.Wednesday)}" +
                $"\nЧТ - {isDay(office3, DaysOfWeek.Thursday)}" +
                $"\nПТ - {isDay(office3, DaysOfWeek.Friday)}" +
                $"\nСБ - {isDay(office3, DaysOfWeek.Saturday)}" +
                $"\nВС - {isDay(office3, DaysOfWeek.Sunday)}");
        }

        [Flags]
        public enum DaysOfWeek
        {
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000,
        }

        public static string isDay(DaysOfWeek office, DaysOfWeek day)
        {
            if ((office & day) == day) return "рабочий";
            return "выходной";
        }
    }
}
