using System;
using System.Linq;
using System.Collections.Generic;

namespace LabDictionariesLambdaAndLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> arr = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            Dictionary<double, int> realNumbers = new Dictionary<double, int>();

            foreach (var num in arr)
            {
                if (!realNumbers.ContainsKey(num))
                {
                    realNumbers.Add(num, 0);
                }
                realNumbers[num]++;
            }
            foreach (var num in realNumbers)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");

            }
        }
    }
}
