using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace EducationProcess
{
    [Serializable]
    internal class Pet
    {
        public string Name {  get; set; }
        public int Age {  get; set; }
        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
