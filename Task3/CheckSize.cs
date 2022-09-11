using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    public static class CheckSize
    {
        public static long CountFiles(DirectoryInfo path)
        {
            long size = 0;

            DirectoryInfo[] infos = path.GetDirectories();
            FileInfo[] arr = path.GetFiles();
            foreach (FileInfo fi in arr)
            {

                size += fi.Length;
            }
            foreach (DirectoryInfo info in infos)
            {
                size += CountFiles(info);
            }

            return size;
        }
    }
}
