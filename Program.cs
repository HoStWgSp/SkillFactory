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
            User user = new User();

            // Setter
            user.Age = 23;
            user.Login = "Lo";
            user.Email = "loginmail.ru";

            // Getter
            Console.WriteLine(user.Age);
            Console.WriteLine(user.Login);
            Console.WriteLine(user.Email);
            Console.ReadKey();
        }
    }
    class User
    {
        private int age;
        private string login, email;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Login
        {
            get { return login; }
            set
            {
                if (value.Length >= 3) login = value;
                else Console.WriteLine("Логин должен быть 3 и более символа!");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains('@')) email = value;
                else Console.WriteLine("Неверный формат электронной почты!");
            }
        }
    }
}
