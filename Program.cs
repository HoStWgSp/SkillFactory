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
        class BaseClass
        {
            public virtual int Counter
            {
                get;
                set;
            }
        }

        class DerivedClass : BaseClass
        {
            public override int Counter
            {
                get {  return Counter; }
                set
                {
                    if (value >= 0) Counter = value;
                }
            }
        }
    }
}
