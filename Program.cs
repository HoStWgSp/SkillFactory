using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace EducationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                temp += arr[i];
            }

            Console.WriteLine(temp);
            Console.ReadKey();
        }
    }
}
