using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProcess
{
    internal static class BinRead
    {
        public static string FileString { get; set; }

        public static void FileInfo(string filePaht)
        {
            if (File.Exists(filePaht))
            {
                using (BinaryReader binaryReader = new BinaryReader(File.Open(filePaht, FileMode.Open)))
                {
                    FileString = binaryReader.ReadString();
                }
                Console.WriteLine("Файл содержит строку: {0}", FileString);
            }
        }
    }
}
