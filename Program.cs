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
        abstract class ComputerPart
        {
            public abstract void Work();
        }

        class Processor : ComputerPart
        {
            public override void Work() { }
        }

        class MotherBoard : ComputerPart
        {
            public override void Work() { }
        }

        class GraphicCard : ComputerPart
        {
            public override void Work() { }
        }
    }
}
