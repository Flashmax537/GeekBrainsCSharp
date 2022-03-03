using System;
using System.Diagnostics;

namespace lesson6Task1
{
    class Program
    {
        static void Main()
        {
            getAllProcesses();

            while (true)
            {
                Console.Write("\nВведите команду: ");
                var action = Console.ReadLine();

                if (action == "id")
                {
                    Console.Write("Введите id: ");
                    if (!int.TryParse(Console.ReadLine(), out int id))
                    {
                        Console.WriteLine("Введено не число!");
                        continue;
                    }
                    Process procById = Process.GetProcessById(id);
                    string procName = procById.ProcessName;
                    procById.Kill();
                    Console.Clear();
                    getAllProcesses();
                    Console.WriteLine($"\nПроцесс \"{procName}\" завершен!");
                }

                if (action == "name")
                {
                    Console.Write("Введите имя процесса: ");
                    string name = Console.ReadLine();
                    Process[] processesByName = Process.GetProcessesByName(name);
                    foreach (var proc in processesByName)
                    {
                        proc.Kill();
                    }
                    Console.Clear();
                    getAllProcesses();
                    Console.WriteLine($"\nПроцесс \"{name}\" завершен!");
                }

                if (action == "exit") break;

                if (action != "id" && action != "name" && action != "exit")
                {
                    Console.WriteLine("Команда не распознана!");
                }
            }
        }
        /// <summary>
        /// Получение списка всех процессов
        /// </summary>
        static void getAllProcesses()
        {
            Process[] processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                string id = process.Id.ToString().PadRight(15);
                Console.WriteLine($"Id: {id} Name: {process.ProcessName}");
            }
            Console.WriteLine("\nЧтобы завершить процесс по ID процесса введите \"id\"" +
                "\nЧтобы завершить процесс по имени процесса введите \"name\"" +
                "\nЧтобы завершить выполнение текущей программы введите \"exit\"");
        }
    }
}
