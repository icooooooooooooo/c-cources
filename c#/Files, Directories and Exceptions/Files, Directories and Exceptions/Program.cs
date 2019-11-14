using System;
using System.IO;

namespace Files__Directories_and_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
//        C: \Users\Hristo\source\repos\Files, Directories and Exceptions\Files, Directories and Exceptions\TextFile1.txt
            string[] text = File.ReadAllLines(@"C:\Users\Hristo\source\repos\Files, Directories and Exceptions\Files, Directories and Exceptions\TextFile1.txt");
            for (int i = 1; i < text.Length; i+=2)
            {
                Console.WriteLine(text[i]);

            }
        }
    }
}
