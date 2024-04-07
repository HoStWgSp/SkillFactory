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
                string dirName = @"C:\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
                if (Directory.Exists(dirName)) // Проверим, что директория существует
                {
                    Console.WriteLine();
                    string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                    Console.WriteLine("Количество папок - {0}", dirs.Length);

                    Console.WriteLine();
                    string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                    Console.WriteLine("Количество файлов - {0}", files.Length);
                }
            }
        

        Console.ReadKey();
        }
    }
}
