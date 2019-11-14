using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keywordsRaw = Console.ReadLine();
            Regex r1 = new Regex(@"([A-Za-z]+)([|,<\\])(.*?)([|,<\\])(\w+)");
            string start = r1.Match(keywordsRaw).Groups[1].Value;
            string end = r1.Match(keywordsRaw).Groups[5].Value;

            List<string> result = new List<string>();

            string textToEdit = Console.ReadLine();
            Regex r2 = new Regex($@"({start})(.*?)({end})");
            MatchCollection matches = r2.Matches(textToEdit);

            foreach (Match match in matches)
            {
                string outcome = match.Groups[2].Value;
                result.Add(outcome);
            }
            Console.WriteLine(string.Join("",result));
        }
    }
}
