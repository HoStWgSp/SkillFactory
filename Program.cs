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
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = () => new Random().Next(0, 100);
 
            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
