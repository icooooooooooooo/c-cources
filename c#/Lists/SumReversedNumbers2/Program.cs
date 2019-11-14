using System;
using System.Linq;
using System.Collections.Generic;

namespace SumReversedNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int length = input.Count;

            for (int i = 0; i < length; i++)
            {
                List<char> breakElement = input[i].ToString().ToList();
                breakElement.Reverse();
                input[i] = int.Parse(string.Join("",breakElement));
            }


            Console.WriteLine(input.Sum());
        }
    }
}
