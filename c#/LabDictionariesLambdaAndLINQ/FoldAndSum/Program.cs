using System;
using System.Linq;
using System.Collections.Generic;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int length = list.Count;

            int piece = length / 4;
            var top = new List<int> { };
            var bottom = new List<int> { };

            top=list.Take(piece);

            Console.WriteLine("Hello World!");
        }
    }
}
