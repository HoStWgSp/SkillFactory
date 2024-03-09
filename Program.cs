using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace EducationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            var numbers = 0;
            int numvar;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            numvar = arr[i, j];
                            arr[i, j] = arr[i, k];
                            arr[i, k] = numvar;
                        }
                    }
                    Console.Write(arr[i, j]);

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
