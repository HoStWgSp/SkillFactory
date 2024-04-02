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
   abstract class Engine
    {

    }
    class ElectricEngine : Engine { }

    class GasEngine : Engine { }

    abstract class CarPart { }

    class Battery : CarPart { }

    class Differential : CarPart { }

    class Wheel : CarPart { }

    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }
    class GasCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            
        }

    }
    class ElectricCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
}
