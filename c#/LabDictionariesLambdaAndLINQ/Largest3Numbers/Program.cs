using System;
using System.Linq;
using System.Collections.Generic;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var result=arr.OrderByDescending(x=>x).Take(3).ToArray();

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
