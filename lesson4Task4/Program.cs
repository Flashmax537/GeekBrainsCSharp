using System;
using System.Collections.Generic;

namespace lesson4Task4
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Длина последовательности: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    var nums = GetFibonacci(number);
                    Console.WriteLine($"Ряд Фибоначчи: {string.Join(", ", nums)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Введено не число!");
                    continue;
                }
            }
        }

        /// <summary>
        /// Получение числа фибоначчи для заданного значения
        /// </summary>
        /// <param name="number">Значение</param>
        /// <returns></returns>
        static int GetFibRec(int number)
        {
            if (number == 0) return 0;
            if (number == 1) return 1;

            return GetFibRec(number - 1) + GetFibRec(number - 2);
        }

        /// <summary>
        /// Получение ряда чисел фибоначчи для заданного значения
        /// </summary>
        /// <param name="number">Значение</param>
        /// <returns></returns>
        static List<int> GetFibonacci(int number)
        {
            List<int> nums = new List<int>();
            if (number >= 0) nums.Add(0);
            if (number >= 1) nums.Add(1);

            for (int i = 2; i <= number; i++)
            {
                nums.Add(GetFibRec(i - 1) + GetFibRec(i - 2));
            }
            return nums;
        }
    }
}
