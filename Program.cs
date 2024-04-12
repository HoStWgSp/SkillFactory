using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using System;
using System.IO;


namespace EducationProcess
{
    internal class Program
    {
        delegate int CalculateDelegate(int a, int b);
        static void Main(string[] args)
        {

            CalculateDelegate calcDelegate = Calculate;

            int result = calcDelegate.Invoke(100, 30);
            Console.WriteLine(result);

            result = calcDelegate.Invoke(100, 30);
            Console.WriteLine(result);

            Console.ReadKey();

        }

        static int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}
