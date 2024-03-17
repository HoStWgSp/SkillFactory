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
            GetArrayFromConsole();

            Console.ReadKey();
        }
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            result = ArraySort.ArraySortUp(result);

            ShowNumbers(result[0], result[2]);

            return result;
        }
        static void ShowNumbers(params int[] colors)
        {
            foreach (var res in colors)
                Console.WriteLine(res);
        }
    }
}
