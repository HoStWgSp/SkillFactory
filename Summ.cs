using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProcess
{
    public class Summ : ISumm
    {
        public double result { get; set; }
        public void Sum(double X, double Y)
        {
            result = X + Y;
        }
    }
}
