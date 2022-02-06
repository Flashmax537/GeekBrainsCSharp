using System;

namespace lesson4Task1
{
    class Program
    {
        static void Main()
        {
            string lastName1 = "Пушкин";
            string firstName1 = "Александр";
            string patronymic1 = "Сергеевич";
            Console.WriteLine(GetFullName(lastName1, firstName1, patronymic1));

            string lastName2 = "Лермонтов";
            string firstName2 = "Михаил";
            string patronymic2 = "Юрьевич";
            Console.WriteLine(GetFullName(lastName2, firstName2, patronymic2));

            string lastName3 = "Тютчев";
            string firstName3 = "Федор";
            string patronymic3 = "Иванович";
            Console.WriteLine(GetFullName(lastName3, firstName3, patronymic3));

            string lastName4 = "Фет";
            string firstName4 = "Афанасий";
            string patronymic4 = "Афанасьевич";
            Console.WriteLine(GetFullName(lastName4, firstName4, patronymic4));
        }

        /// <summary>
        /// Получение объединённой строки с ФИО
        /// </summary>
        /// <param name="firstName">Фамилия</param>
        /// <param name="lastName">Имя</param>
        /// <param name="patronymic">Отчество</param>
        /// <returns></returns>
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + " " + lastName + " " + patronymic;
        }
    }
}
