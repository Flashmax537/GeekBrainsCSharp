using System;
using System.Reflection;

namespace lesson8Task1
{
    class Program
    {
        static void Main()
        {
            //Создать консольное приложение, которое при старте выводит приветствие, записанное в настройках
            //приложения(application - scope).Запросить у пользователя имя, возраст и род деятельности, а затем
            //сохранить данные в настройках.При следующем запуске отобразить эти сведения. Задать
            //приложению версию и описание.
            PrintUserInfo();
            while (true)
            {
                Console.Write("\nВведите команду: ");
                var action = Console.ReadLine();

                if (action.ToLower() == "имя")
                {
                    Console.Write("Введите ваше имя: ");
                    Properties.Settings.Default.UserName = Console.ReadLine();
                }

                if (action.ToLower() == "возраст")
                {
                    Console.Write("Введите ваш возраст: ");
                    Properties.Settings.Default.UserAge = int.Parse(Console.ReadLine());
                }

                if (action.ToLower() == "род")
                {
                    Console.Write("Введите ваш род деятельности: ");
                    Properties.Settings.Default.Profession = Console.ReadLine();
                }

                if (action.ToLower() == "выход")
                {
                    break;
                }
                Properties.Settings.Default.Save();
                PrintUserInfo();
            }
        }

        static void PrintUserInfo()
        {
            string assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            AssemblyDescriptionAttribute descriptionAttribute = executingAssembly.GetCustomAttribute<AssemblyDescriptionAttribute>();
            AssemblyFileVersionAttribute fileVersionAttribute = executingAssembly.GetCustomAttribute<AssemblyFileVersionAttribute>();

            Console.Clear();
            Console.WriteLine($"{Properties.Settings.Default.WelcomeText}" +
                $"\nВаше имя: {Properties.Settings.Default.UserName}" +
                $"\nВаш возраст: {Properties.Settings.Default.UserAge}" +
                $"\nВаш род деятельности: {Properties.Settings.Default.Profession}" +
                $"\n\nAssembly version: {assemblyVersion}" +
                $"\nFile version: {fileVersionAttribute.Version}" +
                $"\nDiscription: {descriptionAttribute.Description}" +
                $"\n\nЧтбы изменить имя введите команду \"Имя\"" +
                $"\nЧтбы изменить возраст введите команду \"Возраст\"" +
                $"\nЧтбы изменить род деятельности введите команду \"Род\"" +
                $"\nЧтбы завершить программу введите команду \"Выход\"");
        }
    }
}
