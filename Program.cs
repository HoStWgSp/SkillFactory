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
            string file = @"C:\Users\gridar\Desktop\Новаяпапка\students.dat";
            List<Student> students = ReadStudentsFromBinFile(file);

            string directory = @"C:\Users\gridar\Desktop\Новаяпапка\Students";

            if (!Directory.Exists(directory))  Directory.CreateDirectory(directory);

            List<string> group = new List<string>();
            foreach (var studentGroup in students)
            {
                if (group.Count == 0)
                {
                    group.Add(studentGroup.Group);
                }
                else
                {
                    bool mach = false;
                    foreach (var g in group)
                    {
                        if (g == studentGroup.Group) mach = true;
                    }
                    if(!mach) group.Add(studentGroup.Group);
                }
            }

            WriteStudentsToBinFile(students, group, directory);

            Console.ReadLine();
        }
        static void WriteStudentsToBinFile(List<Student> students, List<string> groups, string directory)
        {
            foreach (var gr in groups)
            {
                string Directory = directory + @"\" + gr + ".txt";   
                using FileStream fs = new FileStream(Directory, FileMode.Create);
                using BinaryWriter bw = new BinaryWriter(fs);

                foreach (Student student in students)
                {
                    if (student.Group == gr)
                    {
                        bw.Write(student.Name);
                        bw.Write(student.Group);
                        bw.Write(student.DateOfBirth.ToBinary());
                        bw.Write(student.AverageScore);
                    }
                }
                bw.Flush();
                bw.Close();
                fs.Close();
            }

        }

        static List<Student> ReadStudentsFromBinFile(string fileName)
        {
            List<Student> result = new();
            using FileStream fs = new FileStream(fileName, FileMode.Open);
            using StreamReader sr = new StreamReader(fs);

            Console.WriteLine(sr.ReadToEnd());

            fs.Position = 0;

            BinaryReader br = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Student student = new Student();
                student.Name = br.ReadString();
                student.Group = br.ReadString();
                long dt = br.ReadInt64();
                student.DateOfBirth = DateTime.FromBinary(dt);
                student.AverageScore = br.ReadDecimal();

                result.Add(student);
            }

            fs.Close();
            return result;
        }
    }
    internal class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal AverageScore { get; set; }
    }
}
