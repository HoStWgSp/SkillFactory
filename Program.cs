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
    internal class Program
    {

        static void Main(string[] args)
        {
            // объект для сериализации
            var contact = new Contact("Евгений", 89995556325, "fjfjfjf@kfjs.ru");
            Console.WriteLine("Контакт создан");



            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (var fs = new FileStream("Contact.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, contact);
                Console.WriteLine("Контакт сериализован");
            }
            Console.ReadLine();
        }    
    } 
}
