using System;

namespace lesson3Task1
{
    class Program
    {
        static void Main()
        {
            int[,] arr = new int[5, 5]
            {{ 1, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0 },
            { 0, 0, 1, 0, 0 },
            { 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 1 }};

            int padLeft = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j) Console.WriteLine($"{arr[i, j]} ".PadLeft(padLeft += 2));
                }
            }
        }
    }
}
