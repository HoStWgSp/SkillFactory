﻿using System.ComponentModel;
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
        delegate void CalculateDelegate(int a, int b);
        static void Main(string[] args)
        {

            CalculateDelegate calcDelegate = Calculate1;
            calcDelegate += Calculate2;
            calcDelegate -= Calculate2;

            calcDelegate.Invoke(100, 30);


            Console.ReadKey();

        }

        static void Calculate1(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Calculate2(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
