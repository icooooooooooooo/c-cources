using System;
using System.IO;
using System.Text;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = File.ReadAllLines(@"C:\Users\Hristo\source\repos\Files, Directories and Exceptions\Merge Files\FileOne.txt");
            var input2 = File.ReadAllText(@"C:\Users\Hristo\source\repos\Files, Directories and Exceptions\Merge Files\FileTwo.txt").ToString();

            string path = @"C:\Users\Hristo\source\repos\Files, Directories and Exceptions\Merge Files\FileThree.txt";
            var target = File.CreateText(path);
            foreach (var line in input1)
            {
                target = File.AppendAllLines(path, line);

            }
            target = File.AppendAllText(path,input2);

            // not finished

        }
    }
}
