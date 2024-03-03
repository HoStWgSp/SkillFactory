namespace EducationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 5.0 / 2.0;
            Console.WriteLine("5 / 2 = {0}", result);
            result = 5.0 % 2.0;
            Console.WriteLine("5 / 2 = {0}", result);
            int counter = 10;
            Console.WriteLine("Value: {0} Increment: {1}", counter, ++counter);
            counter = 10;
            Console.WriteLine("Value: {0} Increment: {1}", counter, counter++);
            result = 10.0 * 2.0 / 5.0;
            Console.WriteLine("Value: {0}", result);
            result = 10 % 3;
            Console.WriteLine("Value: {0}", result);
            Console.ReadKey();
        }
    }
}
