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
    }
    
    class Car<T>
    {
        public T Engine;
    }
    class ElectricEngine
    {

    }
    class GasEngine
    {

    }

    class Record<T1, T2>
    {
        public T1 Id;
        public DateTime Date;
        public T2 Value;
    }
}
