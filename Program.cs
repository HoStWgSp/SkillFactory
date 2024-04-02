using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace EducationProcess
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Obj obj1 = new Obj { Value = 4 };
            Obj obj2 = new Obj { Value = 5 };

            Obj obj3 = obj1 + obj2;

            Console.WriteLine(obj3.Value);

            Console.ReadKey();
        }
        class Obj
        {
            public int Value;

            public static Obj operator +(Obj a, Obj b)
            {
                return new Obj
                {
                    Value = a.Value + b.Value
                };
            }
            public static Obj operator -(Obj a, Obj b)
            {
                return new Obj
                {
                    Value = a.Value - b.Value
                };
            }
        }
    }
}
