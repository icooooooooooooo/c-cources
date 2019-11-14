using System;
using System.Linq;
using System.Collections.Generic;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(word => word.ToLower()).ToList();

            Dictionary<string, int> counter = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (!counter.ContainsKey(item))
                {
                    counter[item] = 0;
                }
                counter[item]++;
            }

            foreach (var item in counter)
            {
                if (item.Value % 2 != 0)
                {
                    Console.WriteLine(item.Key);
                }

            }
        }
    }
}
