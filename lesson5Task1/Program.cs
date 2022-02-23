using System;
using System.IO;

namespace lesson5Task1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите набор данных: ");
            string data = Console.ReadLine();
            File.AppendAllText("text.txt", data + "\n");
        }
    }
}
