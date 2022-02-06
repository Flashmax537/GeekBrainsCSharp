using System;

namespace lesson3Task3
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            char[] strToCharArr = str.ToCharArray();
            for (int i = strToCharArr.Length - 1; i != -1; i--)
            {
                Console.Write(strToCharArr[i]);
            }
            Console.WriteLine();
        }
    }
}
