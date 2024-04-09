using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProcess
{
    internal static class FolderSize
    {
        public static long DirectorySize(DirectoryInfo dinf)
        {
            long size = 0;

            FileInfo[] fileInfos = dinf.GetFiles();
            foreach(FileInfo fi in fileInfos)
            {
                size += fi.Length;
            }
            DirectoryInfo[] directoryInfos = dinf.GetDirectories();
            foreach(DirectoryInfo di in directoryInfos)
            {
                size += DirectorySize(di);
            }

            return size;
        }
    }
}
