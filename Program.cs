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
using static EducationProcess.Program;


namespace EducationProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Summ summ = new Summ();
            Logger logger = new Logger();

            Console.WriteLine("Введите первое слогаемое");
            double X = DigEnt(logger);
            Console.WriteLine("Введите второе слогаемое");
            double Y = DigEnt(logger);

            summ.Sum(X, Y);

            Console.WriteLine("Результат сложения: {0}", summ.result);

            Console.ReadKey();
        }

        private static double DigEnt(Logger logger)
        {
            double Z;
            while (!Double.TryParse(Console.ReadLine(), out Z))
            {
                logger.Error();
            }
            logger.Event(Z);

            return Z;
        }
    }
}
