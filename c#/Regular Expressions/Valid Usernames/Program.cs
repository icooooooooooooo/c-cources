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
            List<string> input = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string allUsers = string.Join(' ', input);
            MatchCollection matches = r1.Matches(allUsers);

            Dictionary<string,int> dictUsers = new Dictionary<string, int>();

            foreach (Match user in matches)
            {
                string name = user.ToString();
                int length = user.Length;

                dictUsers.Add(name,length);
            }

            var sortedLength = dictUsers.OrderByDescending(x => x.Value);

            Console.WriteLine(string.Join(' ', sortedLength));
        }
    }
}
