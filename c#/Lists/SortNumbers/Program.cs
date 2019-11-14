using System;
using System.Linq;
using System.Collections.Generic;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            nums.Sort();

            Console.WriteLine(string.Join(" <= ",nums));
        }
    }
}
