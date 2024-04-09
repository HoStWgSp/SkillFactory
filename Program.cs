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
            string filePath = @"C:\Users\gridar\Documents\Projects\VisualStudio\SkillFactory\EducationProcess\Program.cs";

            using (StreamReader sr = new StreamReader(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
