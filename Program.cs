using System.Xml.Linq;

namespace EducationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int olddata = 6;
            //byte data = (byte)olddata;
            //Console.WriteLine(data);
            //Console.WriteLine(olddata);

            //olddata = 6;
            //string data = olddata.ToString();
            //Console.WriteLine(data);
            //Console.WriteLine(olddata);

            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is {0} ", age);

            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your age is {0} ", age);

            //Console.Write("Enter your age: ");
            //int age;
            //bool iscorrect = int.TryParse(Console.ReadLine(), out age);
            //Console.WriteLine("Your age is {0} ", age);

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //byte age = (byte)int.Parse(Console.ReadLine());
            //Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //byte age = checked((byte)int.Parse(Console.ReadLine()));
            //Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            //Console.Write("What is your favorite day of week? ");
            //DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
            //Console.WriteLine("Your favorite day is {0}", day);

            //Console.Write("Enter your name: ");
            //var name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //var age = checked((byte)int.Parse(Console.ReadLine()));
            //Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            //Console.Write("What is your favorite day of week? ");
            //var day = (DayOfWeek)int.Parse(Console.ReadLine());
            //Console.WriteLine("Your favorite day is {0}", day);
            //var howItall = 162;
            //var myshoe = 37.5;
            //Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            //Console.WriteLine("What is my grouth? {0} sm", howItall);
            //Console.WriteLine("What is my shoe size? {0}", myshoe);

            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.Write("Enter your age: ");
            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("What is your favorite day of week? ");

            var day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);

            Console.ReadKey();
        }
    }
}
