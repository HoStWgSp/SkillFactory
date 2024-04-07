using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProcess
{
    internal class Drive
    {
        public Drive(string driveName, long totalSpace, long freeSpace)
        {
            DriveName = driveName;
            TotalSpace = totalSpace;
            FreeSpace = freeSpace;
        }
        public string DriveName { get; }
        public long TotalSpace { get; }
        public long FreeSpace { get; }

    }
}
