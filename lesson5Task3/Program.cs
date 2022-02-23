using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lesson5Task3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите набор чисел от 0 до 255, разделенных пробелом: ");
            string[] stringsArray = Console.ReadLine().Split(' ');
            List<int> numbers = new List<int>();

            foreach (var str in stringsArray)
            {
                if (int.TryParse(str, out int num) && num >= 0 && num <= 255)
                {
                    numbers.Add(num);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(str)) Console.WriteLine($"{str} - не подходит по условию!");
                }
            }

            BinaryFormatter formatter = new BinaryFormatter();
            var fileStream = new FileStream("binary.bin", FileMode.OpenOrCreate);
            formatter.Serialize(fileStream, numbers);
            fileStream.Close();

            var deserializeBinFiles = (List<int>) formatter.Deserialize(new FileStream("binary.bin", FileMode.Open));
            Console.WriteLine($"Десериализованный файл: {string.Join(", ", deserializeBinFiles)}");
        }
    }
}
