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
        public class Manager : IManager
        {
            public void Create()
            {

            }

            public void Read()
            {

            }

            public void Update()
            {

            }

            public void Delete()
            {

            }
        }
        public interface IManager
        {
            void Create();
            void Update();
            void Read();
            void Delete();
        }
    }

}
