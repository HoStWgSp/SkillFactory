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

        static void Main(string[] args)
        {
            //FolderClean.ClenFolder(@"C:\Users\gridar\Desktop\Новаяпапка");
            Console.WriteLine(FolderSize.DirectorySize(new DirectoryInfo(@"C:\Users\gridar\Desktop\Новаяпапка")));

            Console.ReadLine();
        }    
    } 
}
