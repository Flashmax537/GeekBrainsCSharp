using System;

namespace lesson2Task1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите минимальную температуру за сутки: ");
            if (!double.TryParse(Console.ReadLine(), out double minT))
            {
                Console.WriteLine("Введено не число!");
                return;
            }
            Console.Write("Введите максимальную температуру за сутки: ");
            if (!double.TryParse(Console.ReadLine(), out double maxT))
            {
                Console.WriteLine("Введено не число!");
                return;
            }
            else if (maxT < minT)
            {
                Console.WriteLine("Максимальная температура должна быть меньше минимальной!");
                return;
            }
            double averageT = (maxT + minT) / 2;
            Console.WriteLine($"Среднесуточная температура: {averageT}");
        }
    }
}
