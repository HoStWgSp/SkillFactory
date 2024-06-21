using EducationProcess.Factories;

namespace EducationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dragon = new Monster(new DragonFactory());
            dragon.Move();
            dragon.Hit();

            Console.WriteLine();

            var orc = new Monster(new OrcFactory());
            orc.Move();
            orc.Hit();  
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
