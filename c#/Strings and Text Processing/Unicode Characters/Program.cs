using System;
using System.Linq;
using System.Collections.Generic;

namespace Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            int length = input.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("\\{0:x4}",(int)input[i]);
            }

        }
    }
}
