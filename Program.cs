namespace EducationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName;
            MyName = "Evgeniy";
            const string MyLastName = "Kuchenin";

            Console.WriteLine("\tПривет, мир");
            Console.WriteLine("\tМне 41 год");
            Console.WriteLine("\tМеня зовут \n\t {0}", MyName);
            Console.WriteLine("\u0023");

            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.WriteLine(5);
            Console.ReadKey();
        }
    }
}
