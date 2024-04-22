using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProcess
{
    public interface ISumm
    {
        void Sum(double X, double Y);
    }
    public interface ILogger
    {
        void Event(double sl);
        void Error();
    }
}
