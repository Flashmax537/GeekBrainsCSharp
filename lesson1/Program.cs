using System;

namespace lesson1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите ваше имя: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now.ToShortDateString()}!");
            Console.ReadKey();
        }
    }
}
