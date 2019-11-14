using System;
using System.Linq;
using System.Collections.Generic;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Read a list of integers in range [0…1000] and print them in ascending order along with their number of occurrences.

            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            /* 
             * After we read the string of numbers from the Console,
             * we are sorting the numbers in order to have them easier to be read.
             */
            nums.Sort();
            List<int> density = new List<int>();
            /*
             * We are initiating the count to be equal to 1, 
             * otherwise we will come short by one when counting the density or if the is only one occurance.
             */
            int count = 1;
            int maxCount = 0;
            int num;
            int maxNum;
            /* 
             * The idea is to create two lists and have on position [i] 
             * where we shall count the occurance of a specific number in one of the lsits 
             * and store the number on the same postion in  the other list.
             */

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    num = nums[i];
                    count++;
                } else if(nums[i - 1] != nums[i])
                {
                    density.Add(count);
                    count = 1;
                }

            }

            Console.WriteLine("Hello World!");


            // Not Finished, as I had to leave. Anticode is here, so I do not forget what I was thinking when creating the code.
        }
    }
}
