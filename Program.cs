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

            Console.ReadKey();
        }
        public class ElectronicBook : IBook, IDevice
        {
            void IBook.Read() { }
            void IDevice.TurnOff() { }
            void IDevice.TurnOn() { }
        }
        public interface IBook
        {
            void Read();
        }

        public interface IDevice
        {
            void TurnOn();
            void TurnOff();
        }
    }
}
