using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProcess
{
    internal static class FileValues
    {

        public static void ValuesRead(string filePaht)
        {
            if (File.Exists(filePaht))
            {
                using (BinaryReader binaryReader = new BinaryReader(File.Open(filePaht, FileMode.Open)))
                {
                    Console.WriteLine($"Файл содержит строку: {binaryReader.ReadString()}");
                }
            }
        }
        public static void ValuesWrite(string filePath)
        {
            if(File.Exists(filePath))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(filePath, FileMode.Open)))
                {
                    binaryWriter.Write($"Файл изменен {DateTime.Now} на компьютере c ОС {Environment.OSVersion}");
                }
            }
        }
    }
}
