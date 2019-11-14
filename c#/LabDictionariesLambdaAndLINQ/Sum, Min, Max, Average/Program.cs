using System;
using System.Linq;
using System.Collections.Generic;

namespace Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i]= int.Parse(Console.ReadLine());
            }

            Console.WriteLine("{0}\n{1}\n{2}\n{3}",arr.Sum(),arr.Min(),arr.Max(),arr.Average());
        }
    }
}
