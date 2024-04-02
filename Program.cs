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
        class Obj
        {
            private string name;
            private string owner;
            private int length;
            private int count;

            public Obj(string name, string ownerName, int objLength, int count)
            {
                this.name = name;
                owner = ownerName;
                length = objLength;
                this.count = count;
            }
        }
    }
}
