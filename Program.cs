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
            Rectangle rectangle = new Rectangle();
            int s = rectangle.Square();

            Console.WriteLine("Площадь треугольника = {0}", s);

            rectangle = new Rectangle(20);
            s = rectangle.Square();

            Console.WriteLine("Площадь треугольника = {0}", s);

            rectangle = new Rectangle(20, 30);
            s = rectangle.Square();

            Console.WriteLine("Площадь треугольника = {0}", s);

            Console.ReadKey();
        }
        
    }
    class Rectangle
    {
        public int a;
        public int b;

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        public Rectangle(int side)
        {
            a = b = side;
        }

        public Rectangle(int firstSide, int secondSide)
        {
            a = firstSide;
            b = secondSide;
        }

        public int Square()
        {
            return a * b;
        }
    }
}
