using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace EducationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);

            Console.ReadKey();
        }
        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            Console.BackgroundColor = (System.ConsoleColor)(ConsoleColor)deep;
            Console.WriteLine("..." + modif);
            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
        public enum ConsoleColor 
        {
            Red = 1,
            Green = 2,
            Blue = 3,
            Cyan = 4,
            Yellow = 5,
            magenta = 6,
        }

    }
}
