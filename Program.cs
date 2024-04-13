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
    class Program
    {
        public delegate Parent HandlerMethod();
        delegate void ChildInfo(Child child);

        public static Parent ParentHandler()
        {
            return null;
        }


        public static Child ChildHandler()
        {
            return null;
        }

        static void Main(string[] args)
        {
            ChildInfo childInfo = GetParentInfo;

            childInfo.Invoke(new Child());

            Console.Read();

        }

        public static void GetParentInfo(Parent p)
        {
            Console.WriteLine(p.GetType());
        }
    }

    class Parent { }

    class Child : Parent { }
}
