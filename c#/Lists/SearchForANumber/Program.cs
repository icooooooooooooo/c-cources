using System;
using System.Linq;
using System.Collections.Generic;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int[] operators = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int toTake = operators[0];     // The idea here seems like we have to take operator[0] amount of numbers and create a list with them;
            int toDelete = operators[1];   // starting from position output[0], remove operator[1] numbers from the list.
            int toLookFor = operators[2];  // look for the number operator[2] in the output List.

            List<int> output = new List<int>();


            // numbers.Take(toTake);
            // 
            // 
            // // for (int i = 0; i < toTake; i++)
            // // {
            // //     output[i]=numbers[i];
            // // }
            // 
            // output.Skip(toDelete);
            // 
            // foreach (var num in output)
            // {
            if (numbers.Take(toTake).Skip(toDelete).Contains(toLookFor))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
