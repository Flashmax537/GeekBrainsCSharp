﻿using System;

namespace lesson3Task4
{
    class Program
    {
        static void Main()
        {
            string[,] battleShip = new string[23, 23] {
                { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
                { "|", "  ", "|", "А", "|", "Б", "|", "В", "|", "Г", "|", "Д", "|", "Е", "|", "Ж", "|", "З", "|", "И", "|", "К", "|" },
                { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
                { "|", " 1", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|" },
                { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
                { "|", " 2", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|" },
                { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
                { "|", " 3", "|", "X", "|", "O", "|", "O", "|", "X", "|", "X", "|", "X", "|", "X", "|", "O", "|", "O", "|", "X", "|" },
                { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
                { "|", " 4", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|" },
                { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
                { "|", " 5", "|", "X", "|", "X", "|", "O", "|", "X", "|", "O", "|", "O", "|", "X", "|", "O", "|", "X", "|", "X", "|" },
                { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
                { "|", " 6", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|" },
                { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
                { "|", " 7", "|", "X", "|", "X", "|", "X", "|", "O", "|", "X", "|", "X", "|", "O", "|", "X", "|", "X", "|", "X", "|" },
                { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
                { "|", " 8", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|" },
                { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
                { "|", " 9", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|" },
                { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
                { "|", "10", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|", "O", "|" },
                { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" }};

            for (int i = 0; i < battleShip.GetLength(0); i++)
            {
                for (int j = 0; j < battleShip.GetLength(1); j++)
                {
                    if (battleShip[i, j] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{battleShip[i, j]} ");
                    }
                    else if (battleShip[i, j] == "O")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{battleShip[i, j]} ");
                    }
                    else if (battleShip[i, j] == "-" || battleShip[i, j] == "|")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"{battleShip[i, j]} ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{battleShip[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
