using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProcess
{
    public class Logger : ILogger
    {
        public void Event(double sl)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Первое слогаемое - {0}", sl);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void Error()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Ведите только цифры. Если число дробное, используйте ',' для разделения.!");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
