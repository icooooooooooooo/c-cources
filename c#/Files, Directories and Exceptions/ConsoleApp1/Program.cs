using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = File.ReadAllText(@"C:\Users\Hristo\source\repos\Files, Directories and Exceptions\ConsoleApp1\TextFile1.txt")
                .Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string[] text = File.ReadAllText(@"C:\Users\Hristo\source\repos\Files, Directories and Exceptions\ConsoleApp1\TextFile2.txt")
                .ToLower()
                .Split(new[] { '\n', ' ', '.', ',', '?', '!','-'}, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var key in keys)
            {
                int count = 0;

                foreach (var word in text)
                {
                    if (key==word)
                    {
                        count++;
                    }
                }
                result.Add(key, count);
                // MatchCollection matches = Regex.Matches(text.ToLower(), key);
                // Console.WriteLine(key + ' ' + matches.Count);
                // not working, as I am not awareat themoment if itis possible to march by keyword and to validate if the subject of the validation is a whole word.
            }
            foreach (var pair in result.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine(pair.Key + ' ' + pair.Value);
            }
        }
    }
}
