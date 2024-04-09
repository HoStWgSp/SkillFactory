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
            ProgInfo();

        Console.ReadKey();
        }
        public static void ProgInfo()
        {
            string tempFile = Path.GetTempFileName(); // используем генерацию имени файла.
            var fileInfo = new FileInfo(tempFile); // Создаем объект класса FileInfo.


            //fileInfo.CreationTime = DateTime.Now;
            //Console.WriteLine("Время открытия файла - {0}", fileInfo.CreationTime);

            //Создаем файл и записываем в него.
            using (StreamWriter sw = fileInfo.CreateText())
            {
                sw.WriteLine("Врем запуска {0}",DateTime.Now);
                sw.WriteLine("Игорь");
                sw.WriteLine("Андрей");
                sw.WriteLine("Сергей");
            }

            //Открываем файл и читаем из него.
            using (StreamReader sr = fileInfo.OpenText())
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }

            try
            {
                string tempFile2 = Path.GetTempFileName();
                var fileInfo2 = new FileInfo(tempFile2);

                // Убедимся, что файл назначения точно отсутствует
                fileInfo2.Delete();

                // Копируем информацию
                fileInfo.CopyTo(tempFile2);
                Console.WriteLine($"{tempFile} скопирован в файл {tempFile2}.");
                //Удаляем ранее созданный файл.
                fileInfo.Delete();
                Console.WriteLine($"{tempFile} удален.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e}");
            }
        }
    }
}
