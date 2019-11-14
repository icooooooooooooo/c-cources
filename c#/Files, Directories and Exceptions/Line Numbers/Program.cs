using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines(@"C:\Users\Hristo\source\repos\Files, Directories and Exceptions\Files, Directories and Exceptions\TextFile1.txt");
            string[] output = new string[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                output[i] = i+1 + ". " + text[i];
            }
            foreach (var line in output)
            {
                Console.WriteLine(line);

            }
        }
    }
}
