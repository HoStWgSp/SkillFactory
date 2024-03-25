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
            Bus bus = new Bus();
            bus.PrintStatus();
            Console.ReadKey();
        }
    }
    class Bus
    {
        public int? Load = 20;

        public void PrintStatus()
        {
            if (Load.HasValue && Load > 0)
                Console.WriteLine("В автобусе {0} пассажиров!", Load.Value);
            else
                Console.WriteLine("Автобус пуст!");
        }
    }
}
