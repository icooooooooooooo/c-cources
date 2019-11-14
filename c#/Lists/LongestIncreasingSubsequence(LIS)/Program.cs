using System;
using System.Linq;
using System.Collections.Generic;

namespace LongestIncreasingSubsequence_LIS_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7 3 5 8 -1 0 6 7	
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> LIS = new List<int>();
            List<int> testLIS = new List<int>();

            int count = 1;
            int maxCount = 0;
            int currentNum = 0;

            List<int> longestSequence = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j =i; j < numbers.Count; j++)
                {

                    currentNum = numbers[i];
                    if (currentNum<numbers[j])
                    {
                        longestSequence.Add(currentNum);
                        currentNum = numbers[j];
                        count++;
                        
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    LIS = longestSequence;
                }
                longestSequence.Clear();
                count = 1;
            }

            Console.WriteLine(string.Join(" ",LIS));


        }
    }
}
