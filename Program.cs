using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace EducationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 41;
            ChangeAge(age);
            Console.WriteLine(age);
            Console.ReadKey();
        }
        static void ChangeAge(int age)
        {
            Console.WriteLine("Введите ваш возраст");
            age = Convert.ToInt32(Console.ReadLine());
        }
    }
}
