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
            protected string Name;

            public BaseClass(string name)
            {
                Name = name;
            }
        }

        class DerivedClass : BaseClass
        {
            public string Description;

            public int Counter;

            public DerivedClass(string name, string description):base(name)
            {
                Description = description;
            }
            public DerivedClass(string name, string description, int counter) : base(name)
            {
                Description = description;
                Counter = counter;
            }
        }
    }
}
