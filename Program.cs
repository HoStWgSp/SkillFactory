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
        public delegate Car HandlerMethod();

        public static Car CarHandler()
        {
            return null;
        }
        public static Lexus LexusHandler()
        {
            return null;
        }

        static void Main(string[] args)
        {
            HandlerMethod handlerLexus = LexusHandler;

            Console.ReadKey();
        }
    }
    class Car { }
    class Lexus : Car { }
}
