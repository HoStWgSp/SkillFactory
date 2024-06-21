

using EducationProcess.Components;

namespace EducationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component rootFolder = new Folder("Root");

            Component myFile = new Components.File("NewFile.txt");

            Folder documentFolder = new Folder("MyDocuments");

            rootFolder.Add(myFile);
            rootFolder.Add(documentFolder);

            Component MyFile2 = new Components.File("NewFile2.txt");
            documentFolder.Add(MyFile2);


            rootFolder.Display();

            Console.ReadKey();
        }
    }
}
