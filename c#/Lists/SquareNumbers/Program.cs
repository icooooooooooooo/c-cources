using System;
using System.Linq;
using System.Collections.Generic;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(s => int.Parse(s))
                .ToList();

            nums.Sort();
            nums.Reverse();

            List<int> squeredNums = new List<int>();

            foreach (int num in nums)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squeredNums.Add(num);
                }
            }

           
                Console.Write(string.Join(" ", squeredNums));
            
        }
    }
}
