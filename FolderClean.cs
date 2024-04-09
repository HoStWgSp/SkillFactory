using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProcess
{
    internal static class FolderClean
    {
        private static string DirectoryPath { get; set; }
        private static int Minutes { get; set; }
        /// <summary>
        /// Данный метод очищает папку по указанному пути немедленно.
        /// Если указано время в минутах, то если папка не использовалась в течении этого времени,
        /// то только тогда она очищается.
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <param name="minutes"></param>
        public static void ClenFolder(string directoryPath, int minutes = 0)
        {
            DirectoryPath = directoryPath;
            Minutes = minutes;

            if (Directory.Exists(DirectoryPath))
            {
                FileInfo fileInfo = new FileInfo(DirectoryPath);

                TimeSpan timeSpan = DateTime.Now.Subtract(fileInfo.LastAccessTime);
                if (timeSpan.TotalMinutes > Minutes)
                {
                    try
                    {
                        string[] directories = Directory.GetDirectories(DirectoryPath);
                        string[] files = Directory.GetFiles(DirectoryPath);

                        foreach (string d in directories)
                        {

                            DirectoryInfo directoryInfo = new DirectoryInfo(d);
                            directoryInfo.Delete(true);


                        }
                        foreach (string f in files)
                        {
                            File.Delete(f);
                        }
                        //Console.WriteLine("Все каталоги из Новаяпапка были удалены");
                    }
                    catch (Exception e) { Console.WriteLine(e); }
                }
                else Console.WriteLine("Данная папка использовалась в заданном промежутке времени!");
            }
            else Console.WriteLine("Данная дериктория не существует");
        }
    }
}
