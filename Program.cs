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
        class A
        {
            public virtual void Display() { Console.WriteLine("A"); }
        }
        class B : A
        {
            public new void Display() { Console.WriteLine("B"); }   
        }
        class C : A
        {
            public override void Display() { Console.WriteLine("C"); }
        }
        class D : B
        {
            public new void Display() { Console.WriteLine("D"); }
        }
        class E : C
        {
            public new void Display() { Console.WriteLine("E"); }
        }
    }
}
