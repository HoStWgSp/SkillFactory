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
            long size = FolderSize.DirectorySize(new DirectoryInfo(@"C:\Users\gridar\Desktop\Новаяпапка"));
            Console.WriteLine($"Исходный размер папки: {size} байт");
            FolderClean.ClenFolder(@"C:\Users\gridar\Desktop\Новаяпапка");
            long size2 = FolderSize.DirectorySize(new DirectoryInfo(@"C:\Users\gridar\Desktop\Новаяпапка"));
            Console.WriteLine($"Было удалено: {size - size2} байт");
            Console.WriteLine($"Текущий размер папки: {size2}");

            Console.ReadLine();
        }    
    } 
}
