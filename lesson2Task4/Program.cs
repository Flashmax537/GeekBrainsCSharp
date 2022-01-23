using System;

namespace lesson2Task4
{
    class Program
    {
        static void Main()
        {
            string shopName = "ООО \"В Космосе Есть\"";
            int chekNumber = 123;
            string cashier = "Галина";
            var date = DateTime.Now.ToString("dd.MM.yy HH:mm");
            string[] dishs = { "Бургер BBQ шаттл", "Бургер Гагарин", "Бургер Кольца Сатурна", "Бургер Веганод" };
            double[] costs = { 320, 300, 350, 250 };
            int[] counts = { 1, 3, 1, 2 };
            double[] sums = { costs[0] * counts[0], costs[1] * counts[1], costs[2] * counts[2], costs[3] * counts[3] };
            double total = sums[0] + sums[1] + sums[2] + sums[3];

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|******************************************|");
            Console.WriteLine($"|********** {shopName} **********|");
            Console.WriteLine("|******************************************|");
            Console.WriteLine("|------------------------------------------|");
            Console.WriteLine($"|Чек №{chekNumber}                                  |");
            Console.WriteLine($"|Кассир: {cashier}                            |");
            Console.WriteLine($"|Дата: {date}                      |");
            Console.WriteLine("|------------------------------------------|");
            Console.WriteLine($"|Блюдо                     Кол-во   Сумма  |");
            Console.WriteLine("|------------------------------------------|");
            Console.WriteLine($"|{dishs[0]}            {counts[0]}      {sums[0].ToString("0.00")} |");
            Console.WriteLine($"|{dishs[1]}              {counts[1]}      {sums[1].ToString("0.00")} |");
            Console.WriteLine($"|{dishs[2]}       {counts[2]}      {sums[2].ToString("0.00")} |");
            Console.WriteLine($"|{dishs[3]}              {counts[3]}      {sums[3].ToString("0.00")} |");
            Console.WriteLine("|------------------------------------------|");
            Console.WriteLine($"|Итого к оплате:                   {total.ToString("0.00")} |");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
