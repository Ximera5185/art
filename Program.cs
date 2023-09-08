using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace art
{
    internal class Program
    {
        static void Main(string [] args)
        {
            string name = GetDataFromUser("Введите ваше имя");

            ChangeConsoleColor(ConsoleColor.Green);

            Console.WriteLine("Данные сохранил!");
            Console.ResetColor();


            string surName = GetDataFromUser("Введите вашу Фамилию:");

            ChangeConsoleColor(ConsoleColor.Yellow);

            Console.WriteLine("Данные сохранил!");
            Console.ResetColor();

            Console.WriteLine($"{name} {surName}");
        }

        public static string GetDataFromUser(string message)
        {
            Console.WriteLine(message);

            string dataFromUser = Console.ReadLine();

            return dataFromUser;
        }

        public static void ChangeConsoleColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }
}

/*Задание 1:
Избавься от дубляжа. Пока без класса, используя создание методов в классе Program.
    class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine("Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Данные сохранил!");
        Console.ResetColor();

        Console.WriteLine("Введите вашу Фамилию: ");
        string surName = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Данные сохранил!");
        Console.ResetColor();

        Console.WriteLine($"{name} {surName}");
    }
}*/
