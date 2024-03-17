using System.Diagnostics;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace EducationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var (Name, Age) = ("Евгений", 41);

            Console.WriteLine("Мое имя {0}", Name);
            Console.WriteLine("Мой возраст {0}", Age);

            Console.Write("Введите имя: ");
            Name = Console.ReadLine();
            Console.Write("Введите возраст цифрами: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Мое имя {0}", Name);
            Console.WriteLine("Мой возраст {0}", Age);

            ShowColor();

            Console.ReadKey();
        }
        static void ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");

                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");

                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is yellow!");

                    break;
            }
        }
    }
}
