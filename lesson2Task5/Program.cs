using System;

namespace lesson2Task5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите порядковый номер текущего месяца: ");
            if (!int.TryParse(Console.ReadLine(), out int monthNumber))
            {
                Console.WriteLine("Введено не число!");
                return;
            }
            string monthTitle = "";
            switch (monthNumber)
            {
                case 1:
                    monthTitle = "Январь";
                    break;
                case 2:
                    monthTitle = "Февраль";
                    break;
                case 3:
                    monthTitle = "Март";
                    break;
                case 4:
                    monthTitle = "Апрель";
                    break;
                case 5:
                    monthTitle = "Май";
                    break;
                case 6:
                    monthTitle = "Июнь";
                    break;
                case 7:
                    monthTitle = "Июль";
                    break;
                case 8:
                    monthTitle = "Август";
                    break;
                case 9:
                    monthTitle = "Сентябрь";
                    break;
                case 10:
                    monthTitle = "Октябрь";
                    break;
                case 11:
                    monthTitle = "Ноябрь";
                    break;
                case 12:
                    monthTitle = "Декабрь";
                    break;
                default:
                    Console.WriteLine("Нет месяца с таким номером!");
                    return;
            }
            Console.WriteLine($"Месяц под номером {monthNumber} - {monthTitle}");

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
            Console.WriteLine("Среднесуточная температура: {averageT}");

            if ((monthNumber <= 2 || monthNumber == 12) && averageT > 0) Console.WriteLine("Дождливая зима");
        }
    }
}
