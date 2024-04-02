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
        class IndexingClass
        {
            private int[] array;

            public IndexingClass(int[] array)
            {
                this.array = array;
            }

            public int this[int index]
            {
                get
                {
                    return array[index];
                }

                set
                {
                    array[index] = value;
                }
            }
        }
    }
}
