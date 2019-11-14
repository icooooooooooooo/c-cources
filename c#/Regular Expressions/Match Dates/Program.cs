using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex regex =new Regex(@"(?<day>\d{2})/(\w{3})/(\d{4})");
            Regex regex2 =new Regex(@"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})"); // initial issue - /2 was /1in regex xpression
            //string r1 = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})";
            ///@"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})"

            string input = Console.ReadLine();
            //"13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016"
            //Match match = regex.Match(input);

            //Match match2 = regex2.Match(input);

            //Console.WriteLine(match.Groups["day"]); //testing -> works
            //Console.WriteLine(match2.Groups["day"]); //testing -> not working - likely regex issue

            var matches = regex2.Matches(input); 


            foreach (Match element in matches)
            {
                var day = element.Groups["day"].Value;
                var month = element.Groups["month"].Value;
                var year = element.Groups["year"].Value;
                
                Console.WriteLine($"Day:{day}, Month:{month}, Year:{year}");
                Console.WriteLine(element);

            }
        }
    }
}
