using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace EducationProcess
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Pen pen = new Pen();
            pen.Greetings();

            Console.ReadKey();
        }
        
    }
    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "Черный";
            cost = 100;
        }
        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }

        public void Greetings()
        {
            Console.WriteLine("Цвет {0}, стоимость {1}", color, cost);
        }
    }
}
