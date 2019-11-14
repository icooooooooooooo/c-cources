using System;
using System.Text;

namespace Strings_and_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            

            char[] output = new char[input.Length];
            for (int i = input.Length - 1; i >= 0; i--)
            {
                
                    output[i] += input[input.Length-1-i];
                
            }
            string result = new String(output);
            Console.WriteLine(result);
        }
    }
}

