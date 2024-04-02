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
           

            Console.ReadKey();
        }
        class Obj
        {
            public string Name;
            public string Description;

            public static string Parent;
            public static int DaysInWeek;
            public static int MaxValue;

            static Obj()
            {
                Parent = "System.Object";
                DaysInWeek = 7;
                MaxValue = 2000;
            }
        }
    }
}
