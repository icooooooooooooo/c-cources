using System;
using System.Text.RegularExpressions;

namespace Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r1 = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");

            string input = Console.ReadLine();

            var numbers = r1.Matches(input);
            foreach (Match number in numbers)
            {
                Console.WriteLine(number.Value + " ");
            }
            Console.WriteLine(" ");
        }
    }
}
