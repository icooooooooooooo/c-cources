using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxSequenceОfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //numbers.Sort(); - this will break the output. 

            int count = 1;
            int maxCount = 0;
            int maxNumber = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    count++;                    
                }
                else if (numbers[i - 1] != numbers[i])
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxNumber = numbers[i - 1];
                    }
                    count = 1;
                }
                if (i == numbers.Count-1)
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxNumber = numbers[i - 1];
                    }
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxNumber);

            }
        }
    }
}
