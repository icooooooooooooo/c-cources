using System;
using System.Linq;
using System.Collections.Generic;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome to SoftUni and have fun learning programming
            List<string> list = Console.ReadLine().Split(" ").ToList();
            Random auto = new Random();
            string tempHolder = null;

            for (int i = 0; i < list.Count; i++)
            {
                tempHolder = list[i];
                int newPosition = auto.Next(list.Count);
                list[i] = list[newPosition];
                list[newPosition] = tempHolder;
            }

            Console.WriteLine(string.Join(" ",list));
        }
    }
}
