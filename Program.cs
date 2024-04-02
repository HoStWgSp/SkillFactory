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
            int num1 = 3;
            int num2 = 58;

            Helper.Swap(ref num1, ref num2);

            Console.WriteLine(num1); 
            Console.WriteLine(num2); 

            Console.ReadKey();
        }
        class Helper()
        {
            public static void Swap(ref int a, ref int b)
            {
                int c = a;
                a = b;
                b = c;
            }
        }
    }
}
