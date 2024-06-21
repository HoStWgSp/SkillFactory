using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProcess.Movements
{
    class RunMovement: IMovement
    {
        public void Start()
        {
            Console.WriteLine("Бежим");
        }
    }
}
