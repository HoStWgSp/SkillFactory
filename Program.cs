namespace EducationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Evgeniy";
            byte MyAge = 41;
            bool HaveIApet = true;
            double MyShoeSize = 40.5;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.WriteLine("IntMin {0} ", int.MinValue);
            Console.WriteLine("IntMax {0} ", int.MaxValue);

            Console.ReadKey();
        }
    }
}
