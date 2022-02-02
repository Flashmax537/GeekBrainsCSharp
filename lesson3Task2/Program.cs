using System;

namespace lesson3Task2
{
    class Program
    {
        static void Main()
        {
            string[,] phoneBook = new string[5, 2]
                {{ "Пожарная охрана", "101" },
                { "Плиция", "102" },
                { "Скорая помощ", "103" },
                { "Аварийная газовая", "104" },
                { "Единая служба спасения", "112" } };

            Console.WriteLine("Телефоны вызова экстенных служб:");
            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                for (int j = 0; j < phoneBook.GetLength(1); j++)
                {
                    Console.Write($"{phoneBook[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
