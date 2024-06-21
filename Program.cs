
using EducationProcess.Components;

namespace EducationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IdeFacade ideFacade = new IdeFacade(new Editor(), new Compiller(), new Runtime());

            ideFacade.Start("Console.WriteLine(\"Hello World!\");");
            ideFacade.Stop();

            Console.ReadKey();
        }
    }
}
