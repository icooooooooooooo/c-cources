using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex surface = new Regex(@"(\W+)");
            Regex mantle = new Regex(@"([0-9_]+)");
            Regex core = new Regex(@"(\W+)([0-9_]+)([A-Za-z]+)([0-9_]+)(\W+)");

            Regex coreOnly = new Regex(@"([A-Za-z]+)");

            Regex[] validation = new Regex[5]
            {
                surface,
                mantle,
                core,
                mantle,
                surface
            };

            string[] input = new string[5];
           
            int coreCount = 0;
            for (int i = 0; i < 5; i++)
            {
                input[i] = Console.ReadLine();

                if (!validation[i].IsMatch(input[i]))
                {
                    Console.WriteLine("Invalid");
                    break;
                }
                if (i==2)
                {
                    var extractCore = coreOnly.Match(input[i]).ToString();
                    coreCount = extractCore.Length;
                }
            }

            if (coreCount != 0)
            {
                Console.WriteLine($"Valid!\n{coreCount}");
            }
        }
    }
}
