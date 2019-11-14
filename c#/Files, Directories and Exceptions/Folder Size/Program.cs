using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"C:\"); //.Select(f => new FileInfo(f)).ToArray();
            double sizeSum = 0;
            foreach (var file in files)
            {
                var fileinfo = new FileInfo(file);

                sizeSum += (double)fileinfo.Length;
            }

            Console.WriteLine(sizeSum/1024/1024);
        }
    }
}
