using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] spaces = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Regex pattern = new Regex(@"[|<]+([A-Za-z]{"+ spaces[0] + @"})([A-Za-z]{1," + spaces[1] + "})");
            string input = Console.ReadLine();

            List<string> output = new List<string>();

            MatchCollection matches = pattern.Matches(input);
            foreach (Match match in matches)
            {
                output.Add(match.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
