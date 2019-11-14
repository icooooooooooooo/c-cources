using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r1 = new Regex (@"(^|(?<=\s))(?:([a-zA-z0-9]+)([-._][a-zA-z0-9]*)*)@([a-z]+(?:-*[a-z]*)(?:\.[a-z]+)+)");

            //string pattern = @"(^|(?<=\s))(?:([a-zA-z0-9]+)([-._][a-zA-z0-9]*)*)@([a-z]+(?:-*[a-z]*+)(?:\.[a-z]+)+)";
            // (^|(?<=\s))(?:[A-Za-z0-9](?:[-._]*[A-Za-z0-9])*)@(?:(?:[A-Za-z](?:-*[A-Za-z])*)(?:\.[A-Za-z](?:-*[A-Za-z])*)+)
            string input = Console.ReadLine();

            MatchCollection result = r1.Matches(input);

            foreach (Match match in result)
            {
                Console.WriteLine(match+" ");
            }

        }
    }
}
