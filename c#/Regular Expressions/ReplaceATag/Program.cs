using System;
using System.Text.RegularExpressions;

namespace ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            var regexNew = @"[URL href=$1]$2[/URL]";
            string input = Console.ReadLine();
            
            while (input!="end")
            {
                string replaced = Regex.Replace(input, regex, regexNew);
                Console.WriteLine(replaced);
                input = Console.ReadLine();
            }
        }
    }
}
