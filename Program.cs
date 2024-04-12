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
            try
            {
                throw new RankException("Сообщение об ошибке");
            }

            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType);
            }

            finally
            {
                Console.Read();
            }

            Console.ReadKey();
        }
    }
}
