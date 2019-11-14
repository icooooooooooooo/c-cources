using System;
using System.Linq;
using System.Collections.Generic;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numsList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            /* List<decimal> numsList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
             * 
             * using System.Linq;
             * using System.Collections.Generic;
             * 
             */


            // string input = Console.ReadLine();
            // List<string> textOfNums = input.Split(' ').ToList();
            // List<decimal> numsList = new List<decimal>();
            // 
            // for (int i = 0; i < textOfNums.Count; i++)
            // {
            //     numsList.Add(decimal.Parse(textOfNums[i]));
            // }
            /* Manually parsing the string into decimal,
             * this is allowing us to practice Lists without the use of Collections.Generic or Linq */

            for (int i = 1; i < numsList.Count; i++)
            {
                if (numsList[i-1] == numsList[i])
                {
                    numsList[i-1] += numsList[i];
                    numsList.RemoveAt(i);
                    i=0;
                }
            }

            foreach (var num in numsList)
            {
                Console.Write(num);
            }
            Console.WriteLine();
        }
    }
}
