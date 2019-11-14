using System;
using System.Linq;
using System.Collections.Generic;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int length = input.Count();

            for (int i = 0; i < length; i++)
            {
                string reversed = null;
                int number = input[i];
                while (number > 0)
                {
                    reversed += (number % 10).ToString();
                    number /= 10;
                }
                input[i] = int.Parse(reversed);
            }


            Console.WriteLine(input.Sum());

            //I am not sure if this is the optimal solution.

            //This one is resolved in an alternative manner by using char list.
        }
    }
}
