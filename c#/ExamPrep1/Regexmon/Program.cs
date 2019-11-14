using System;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex bojomon = new Regex(@"\w+-\w+");
            Regex didimon = new Regex(@"[^-|\w]+");

            int i = 0;
            while (bojomon.IsMatch(input)||didimon.IsMatch(input))
            {
                if (i % 2 == 0) // didimon turn
                {
                Match found = didimon.Match(input);
                //method is sutitable here
                Console.WriteLine(found);
                int lenghtToRemove = found.Length;
                int position = found.Index;

                input = input.Remove(0, position + lenghtToRemove);
                }
                else if (i % 2 != 0) //bojomon turn
                {
                Match found = bojomon.Match(input);
                Console.WriteLine(found);
                int lenghtToRemove = found.Length;
                int position = found.Index;

                input = input.Remove(0, position + lenghtToRemove);
                }
                i++;
            }
        }
    }
}
