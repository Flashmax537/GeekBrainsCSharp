using System;
using System.IO;

namespace lesson5Task2
{
    class Program
    {
        static void Main()
        {
            File.AppendAllText("startup.txt", DateTime.Now.ToString("Время запуска: HH:mm:ss") + "\n");
        }
    }
}
