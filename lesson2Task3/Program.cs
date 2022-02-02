using System;

namespace lesson2Task3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Введено не число!");
                return;
            }
            if (number % 2 == 0)
            {
                Console.WriteLine("Число чётное!");
            }
            else
            {
                Console.WriteLine("Число не чётное!");
            }
        }
    }
}
