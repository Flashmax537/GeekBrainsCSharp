using System;

namespace lesson4Task2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите набор чисел, разделенных пробелом: ");
            int sum = GetSumNumbers(Console.ReadLine());
            Console.WriteLine($"Сумма: {sum}");
        }

        /// <summary>
        /// Получение суммы всех чисел в строке, разделенных пробелом
        /// </summary>
        /// <param name="str">Строка с набором чисел</param>
        /// <returns></returns>
        static int GetSumNumbers(string str)
        {
            int result = 0;
            string number = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    number += str[i];
                }
                if (str[i] == ' ' || i == str.Length - 1)
                {
                    if (!int.TryParse(number, out int num))
                    {
                        if (!string.IsNullOrWhiteSpace(number)) Console.WriteLine($"{number} - не число!");
                    }
                    result += num;
                    number = "";
                }
            }
            return result;
        }
    }
}
