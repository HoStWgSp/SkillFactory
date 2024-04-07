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
                GetCatalogs(); //   Вызов метода получения директорий
            

            static void GetCatalogs()
            {
                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\gridar\Desktop\testFolder");

                    if (!dirInfo.Exists)
                    {
                        dirInfo.Create();
                        Console.WriteLine("Каталог создан");
                    }
                    string newPath = @"C:\Users\gridar\Desktop\Новаяпапка\testFolder";
                    dirInfo.MoveTo(newPath);

                    Console.WriteLine("Директория перемещена в Корзину");

                    //DirectoryInfo newDirectory = new DirectoryInfo(@" / newDirectory");
                    //if (newDirectory.Exists)

                    //    newDirectory.Delete(true);
                    //Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        

        Console.ReadKey();
        }
    }
}
