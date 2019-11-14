using System;
using System.Linq;
using System.Collections.Generic;

namespace Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(new char[] { ':', '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length < 5)
                .Select(word => word.ToLower())
                .OrderBy(word => word)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", text));
        }

    }
}
