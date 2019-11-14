using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+\d{3}( |-)[0-9]{1}\1[0-9]{3}\1[0-9]{4}\b";
            string input = Console.ReadLine();
            List<string> phones = new List<string>();

            MatchCollection matches = Regex.Matches(input,regex);
            foreach (var match in matches)
            {
                phones.Add(match.ToString());

            }
            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
