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
        class BaseClass
        {
            public virtual void Display()
            {
                Console.WriteLine("Метод класса BaseClass");
            }
        }

        class DerivedClass : BaseClass
        {
            public override void Display()
            {
                base.Display();
                Console.WriteLine("Метод класса DerivedClass");
            }
        }
    }
}
