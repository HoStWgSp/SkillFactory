using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace EducationProcess
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.ReadKey();            
        }
    }
    class Engine
    {

    }
    class ElectricEngine : Engine { }

    class GasEngine : Engine { }

    class CarPart { }

    class Battery : CarPart { }

    class Differential : CarPart { }

    class Wheel : CarPart { }

    class Car<T1> where T1 : Engine
    {
        public T1 Engine;

        public virtual void ChangePart<T2>(T2 newPart) where T2 : CarPart
        {

        }
    }
    //class Car<T1>
    //{
    //    public T1 Engine;
    //    public virtual void ChangePart<T2>(T2 newPart)
    //    {

    //    }
    //}
    //class ElectricEngine
    //{

    //}
    //class GasEngine
    //{

    //}

    //class Battery
    //{

    //}
    //class Differential
    //{

    //}
    //class Wheel
    //{

    //}
}
