using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
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
            Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

            void CreateFolder(string name)
            {
                Folders.Add(name, new Folder());
            }
            Console.ReadKey();            
        }
    }
}
