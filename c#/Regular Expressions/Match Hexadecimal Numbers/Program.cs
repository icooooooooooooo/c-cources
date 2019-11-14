using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?:0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();

            var numbers = Regex.Matches(input, regex).Cast<Match>().Select(x => x.Value).ToArray();
            

            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
