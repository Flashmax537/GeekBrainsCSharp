using System;

namespace lesson3Task3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите текст: ");
            string str = Console.ReadLine();
            char[] strToCharArr = str.ToCharArray();
            Console.Write("Текст в обратном порядке: ");
            for (int i = strToCharArr.Length - 1; i != -1; i--)
            {
                Console.Write(strToCharArr[i]);
            }
        }
    }
}
