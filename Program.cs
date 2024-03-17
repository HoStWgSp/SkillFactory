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
            var array = GetArrayFromConsole(10);
            ShowNumbers(array, true);
            Console.ReadKey();
        }
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        static void ShowNumbers(int[] result, bool IsSort = false)
        {
            var temp = result;
            if(IsSort) 
                ArraySort.ArraySortUp(temp); 
            foreach (var res in temp)
                Console.WriteLine(res);
        }
    }
}
