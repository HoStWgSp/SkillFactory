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
using System.Security.Cryptography;
using System.Runtime.Serialization;


namespace EducationProcess
{
    class Program
    {
        static List<string> lastNames = new List<string>() { "Недоразвитовы", "Дебиловы", "Дацновы", "Имбициловы", "Недоношеновы" };
        static void Main(string[] args)
        {
            Sort sort = new Sort();
            sort.SortEvent += ShowSort;
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    sort.Read();
                    tryAgain = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите 1 или 2");
                }
            }
            Console.ReadKey();
        }
        static void ShowSort(int number)
        {
            switch (number)
            {
                case 1:
                    var lnOne = lastNames.OrderBy(n => n);
                    Console.WriteLine("Сортировка от А до Я:");
                    foreach (string lno in lnOne)
                    {
                        Console.Write(lno + " ");
                    }

                break;
                case 2:
                    var lnTwo = lastNames.OrderByDescending(n => n);
                    Console.WriteLine("Сортировка от А до Я:");
                    foreach (string lnt in lnTwo)
                    {
                        Console.Write(lnt + " ");
                    }
                break;
            }
        }
    }

}
