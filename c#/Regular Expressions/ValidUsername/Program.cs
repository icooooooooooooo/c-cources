using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r1 = new Regex(@"(^|(?<=\s))([A-Za-z]\w{2,25})");
            string[] input = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> list = new List<string>();
            foreach (var username in input)
            {
                if (r1.IsMatch(username))
                {
                    list.Add(username);
                }
            }

            int position = 0 ;
            int countLength = 0;
            int countLengthMax = 0;

            /*
             * sum the length of every 2 consecutive valid usernames and 
             * print the 2 valid usernames with biggest sum of their lengths, 
             * on the console, each on a separate line. 
             */

            for (int i = 0; i < list.Count-1; i++)
            {
                countLength = list[i].Length + list[i+1].Length;

                if (countLength>countLengthMax)
                {
                    countLengthMax = countLength;
                    position = i;
                }                
            }

            Console.WriteLine(list[position]);
            Console.WriteLine(list[position+1]);
        }
    }
}
