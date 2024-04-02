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
            
            Console.ReadKey();
        }
        class Food { }

        class Fruit : Food { }

        class Vegetable : Food { }

        class Apple : Fruit { }

        class Banana : Fruit { }

        class Pear : Fruit { }

        class Potato : Vegetable { }

        class Carrot : Vegetable { }
    }
}
