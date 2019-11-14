using System;
using System.Linq;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //int length = int.Parse(Console.ReadLine());

            string values = Console.ReadLine();
            List<string> numInText = values.Split(" ").ToList();
            List<int> numbers = new List<int>();


            for (int i = 0; i < numInText.Count; i++)
            {
                numbers.Add(int.Parse(numInText[i]));
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.Write("empty");
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
