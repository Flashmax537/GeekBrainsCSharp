using System;

namespace lesson4Task3
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Введите номер месяца: ");
                if (!int.TryParse(Console.ReadLine(), out int numberMonth))
                {
                    Console.WriteLine("Введено не число!");
                    continue;
                }

                if (0 < numberMonth && numberMonth < 13)
                {
                    string season = GetSeason(numberMonth);
                    Console.WriteLine($"Время года: {season}");
                    break;
                }
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                continue;
            }
        }

        /// <summary>
        /// Определение времени года по номеру месяца
        /// </summary>
        /// <param name="numberMonth">Номер месяца</param>
        /// <returns></returns>
        static string GetSeason(int numberMonth)
        {
            int maskMonth = 1 << numberMonth - 1; // побитовое смещение, для выставления маски месяца

            if ((maskMonth & (int)season.Winter) == maskMonth) return "Зима";
            if ((maskMonth & (int)season.Spring) == maskMonth) return "Весна";
            if ((maskMonth & (int)season.Summer) == maskMonth) return "Лето";
            if ((maskMonth & (int)season.Autumn) == maskMonth) return "Осень";

            return "Ошибка: введите число от 1 до 12";
        }

        [Flags]
        public enum season
        {
            Winter = 0b_100000000011,
            Spring = 0b_000000011100,
            Summer = 0b_000011100000,
            Autumn = 0b_011100000000
        }
    }
}
