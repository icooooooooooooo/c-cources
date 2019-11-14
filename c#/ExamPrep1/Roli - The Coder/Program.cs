using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace Roli___The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

            Dictionary<int, string> sportValidation = new Dictionary<int, string>();

            Regex r1 = new Regex(@"(#)");
            //•	{id} #{eventName} @{participant1} @{participant2} … @{participantN}
            // 1 #Beers @roli @trophon @alice

            while (input[0] != "Time")
            {
                if (!sportValidation.ContainsKey(int.Parse(input[0])))
                {
                    sportValidation.Add(int.Parse(input[0]), input[1]);
                }
                else
                {

                }

                if (sportValidation[int.Parse(input[0])].Contains(input[1]))
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        input[i] = r1.Replace(input[i], "");
                    }


                    if (!output.ContainsKey(input[1]))
                    {

                        List<string> members = new List<string>();
                        for (int i = 2; i < input.Length; i++)
                        {
                            members.Add(input[i]);
                        }
                        output.Add(input[1], members);
                    }
                    else if (output.ContainsKey(input[1]))
                    {
                        for (int i = 2; i < input.Length; i++)
                        {
                            if (!output[input[1]].Contains(input[i]))
                            {
                                output[input[1]].Add(input[i]);
                            }
                        }
                    }
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }

            foreach (var sport in output.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{sport.Key} - {sport.Value.Count}");
                foreach (var member in sport.Value)
                {
                    Console.WriteLine(member);
                }
            }

            //Console.WriteLine(string.Join(" ", sportValidation));
        }
    }
}
