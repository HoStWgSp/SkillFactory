using System.Diagnostics;
using System.Runtime.ExceptionServices;
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
            Console.WriteLine("Мой возраст‚ {0}", Age);

            Console.Write("Введите имя: ");
            Name = Console.ReadLine();
            Console.Write("Укажите возраст цифрами: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя {0}", Name);
            Console.WriteLine("Ваш возраст‚ {0}", Age);

            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++) 
            {
                favcolors[i] = ShowColor(Name); 
            }

            foreach (var color in favcolors)
            {
                Console.WriteLine("Ваши любимые цвета: {0}", color);
            }

            Console.ReadKey();
        }
        static string ShowColor(string username)
        {
            Console.WriteLine("Введите любимый цвет");
            string color = Console.ReadLine();
            switch (color)
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
            return color;
        }
    }
}
