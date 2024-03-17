using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace EducationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteUserData();
            Console.ReadKey();
        }
        static (string Name, string LastName, int Age, bool Pet, int PetCount, string[] PetNames, bool Flowers, int FlowerCount, string[] FavFlowers) EnterUser()
        {
            (string Name, string LastName, int Age, bool Pet, int PetCount, string[] PetNames, bool Flowers, int FlowerCount, string[] FavFlowers) User;

            string readLine;
            int count;

            do
            {
                Console.WriteLine("Введите ваше имя. Используйте только буквы");
                readLine = Console.ReadLine();
            
            } while (!Regex.IsMatch(readLine, @"^[a-zA-Zа-яА-Я]+$"));
            User.Name = readLine;

            do
            {
                Console.WriteLine("Введите вашу фамилию. Используйте только буквы");
                readLine = Console.ReadLine();
            } while (!Regex.IsMatch(readLine, @"^[a-zA-Zа-яА-Я]+$"));
            User.LastName = readLine;

            do
            {
                Console.WriteLine("Введите ваш возраст цифрами");
                readLine = Console.ReadLine();
            }while(CheckNum(readLine, out User.Age));

            Console.WriteLine("Есть ли у вас питомцы?\nВведите (Да) или (Нет)");
            
            readLine = Console.ReadLine();
            while(Answer(readLine))
            {
                Console.WriteLine("Введите (Да) или (Нет)");
                readLine = Console.ReadLine();
            }
            if (readLine == "Да")
            {
                User.Pet = true;
                do
                {
                    Console.WriteLine("Напишите их количество цифрами");
                    readLine = Console.ReadLine();
                } while (CheckNum(readLine, out count));
                User.PetCount = count;
                User.PetNames = new string[count];
                for (int i = 0; i < count; i++)
                {
                    do
                    {
                        Console.WriteLine("Напишите имя питомцы {0}", i + 1);
                        readLine = Console.ReadLine();
                    } while (!Regex.IsMatch(readLine, @"^[a-zA-Zа-яА-Я]+$"));
                    User.PetNames[i] = readLine;
                }
            }
            else
            {
                User.Pet = false;
                User.PetCount = 0;
                User.PetNames = new string[0];
            }


            Console.WriteLine("Есть ли у вас любимые цветы?\nВведите (Да) или (Нет)");


            readLine = Console.ReadLine();
            while (Answer(readLine))
            {
                Console.WriteLine("Введите (Да) или (Нет)");
                readLine = Console.ReadLine();
            }
            if (readLine == "Да")
            {
                User.Flowers = true;
                do
                {
                    Console.WriteLine("Напишите их количество цифрами");
                    readLine = Console.ReadLine();
                } while (CheckNum(readLine, out count));
                User.FlowerCount = count;
                User.FavFlowers = new string[count];
                for (int i = 0; i < count; i++)
                {
                    do
                    {
                        Console.WriteLine("Напишите навание цветка {0}", i + 1);
                        readLine = Console.ReadLine();
                    } while (!Regex.IsMatch(readLine, @"^[a-zA-Zа-яА-Я]+$"));

                    User.FavFlowers[i] = readLine;
                }
            }
            else
            {
                User.Flowers = false;
                User.FlowerCount = 0;
                User.FavFlowers = new string[0];
            }

            return User;

            bool Answer(string answer)
            {
                if (answer == "Да")
                    return false;
                else if (answer == "Нет")
                    return false;
                else return true;
            }
        }
        static bool CheckNum(string number, out int correctnum)
        {
            if (int.TryParse(number, out int num))
            {
                if (num >= 1)
                {
                    correctnum = num;
                    return false;
                }
            }
            {
                correctnum = 0;
                return true;
            }
        }
        static void WriteUserData()
        {

            var User = EnterUser();
            Console.WriteLine();
            Console.WriteLine("Ваше полное имя {0} {1}", User.LastName, User.Name);
            Console.WriteLine("Ваш возраст {0} лет", User.Age);
            if (User.Pet)
            {
                Console.WriteLine("У вас {0} домашних животнх", User.PetCount);
                if (User.PetCount == 1)
                    Console.Write("Его зовут - ");
                else
                    Console.WriteLine("Их зовут:");
                int i = 1;
                foreach (string pet in User.PetNames)
                {
                    Console.WriteLine("{0}-{1}",i, pet);
                    i++;
                }
            }
            else Console.WriteLine("У вас нет домашних животных");

            if (User.Flowers)
            {
                Console.WriteLine("У вас {0} любимых цветов", User.FlowerCount);
                if (User.FlowerCount == 1)
                    Console.Write("Его название - ");
                else
                    Console.WriteLine("Их названия:");
                int i = 1;
                foreach (string flower in User.FavFlowers)
                {
                    Console.WriteLine("{0}-{1}", i, flower);
                    i++;
                }
            }
            else Console.WriteLine("У вас нет любимых цветков");
        }
    }
}
