namespace EducationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Semaphore semaphoreLight;

            semaphoreLight = Semaphore.GREEN;

            Console.WriteLine(semaphoreLight);
            Console.ReadKey();
        }

        enum Semaphore
        {
            RED = 100,
            YELLOW = 200,
            GREEN = 300
        }
    }
}
