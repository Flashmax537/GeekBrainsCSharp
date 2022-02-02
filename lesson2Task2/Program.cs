using System;

namespace lesson2Task2
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
        }
    }
}
