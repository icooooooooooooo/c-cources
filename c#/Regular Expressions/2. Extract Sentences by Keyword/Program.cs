using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _2._Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string separatorWord = Console.ReadLine();
            //var separator = new Regex($@"(?:(\w+)*) {0} (?:(\w+)*)", separatorWord);
            Regex r1 = new Regex($@"\b{separatorWord}\b");
            string[] input = Console.ReadLine().Split(new[] { '.', '?', '!' } , StringSplitOptions.RemoveEmptyEntries).ToArray();
            var sentences = new List<string>();

            foreach (var sentence in input)
            {
                sentences.Add(sentence.Trim());
            }

            foreach (var sentence in sentences)
            {
                if (r1.IsMatch(sentence))
                {
                    Console.WriteLine(sentence);
                }

            }
        }
    }
}
