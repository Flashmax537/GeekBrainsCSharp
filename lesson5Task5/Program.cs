using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace lesson5Task5
{
    class Program
    {
        static void Main()
        {
            var toDoList = new List<ToDo>();
            if (File.Exists("tasks.json"))
            {
                string deserializeJson = File.ReadAllText(("tasks.json"));
                if (!string.IsNullOrWhiteSpace(deserializeJson)) toDoList = JsonSerializer.Deserialize<List<ToDo>>(deserializeJson);
            }

            string json = JsonSerializer.Serialize(toDoList);
            File.WriteAllText("tasks.json", json);

            Console.WriteLine("Чтобы добавить задачу введите \"+\"" +
                "\nЧтобы посмотреть текущие задачи введите \"list\"" +
                "\nЧтобы отметить выполненную задачу введите \"x\"" +
                "\nЧтобы завершить программу введите \"exit\"");

            while (true)
            {
                Console.Write("\nДействие: ");
                var input = Console.ReadLine();

                if (input == "+")
                {
                    Console.Write("Введите текст задачи: ");
                    var task = Console.ReadLine();
                    toDoList.Add(new ToDo() { Title = task, IsDone = false });
                    json = JsonSerializer.Serialize(toDoList);
                    File.WriteAllText("tasks.json", json);
                }

                if (input == "list")
                {
                    string deserializeJson = File.ReadAllText(("tasks.json"));
                    var tasks = JsonSerializer.Deserialize<List<ToDo>>(deserializeJson);
                    if (tasks.Count > 0)
                    {
                        for (int i = 0; i < tasks.Count(); i++)
                        {
                            Console.WriteLine($"{(tasks[i].IsDone ? "[x]" : "[ ]")} {i + 1}. {tasks[i].Title}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Список задач пуст!");
                    }
                }

                if (input == "x")
                {
                    Console.Write("Введите номер задачи: ");
                    var taskNumber = Console.ReadLine();

                    string deserializeJson = File.ReadAllText(("tasks.json"));
                    var tasks = JsonSerializer.Deserialize<List<ToDo>>(deserializeJson);

                    for (int i = 0; i < tasks.Count(); i++)
                    {
                        if ($"{i + 1}" == taskNumber.ToString()) tasks[i].IsDone = true;
                    }
                    json = JsonSerializer.Serialize(tasks);
                    File.WriteAllText("tasks.json", json);
                }

                if (input == "exit") break;

                if (input != "+" && input != "list" && input != "x" && input != "exit")
                {
                    Console.WriteLine("Команда не распознана");
                }
            }
        }
    }

    /// <summary>
    /// Класс задач
    /// </summary>
    public class ToDo
    {
        /// <summary>
        /// Описание задачи
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Отметка о выполнении задачи
        /// </summary>
        public bool IsDone { get; set; }
    }
}
