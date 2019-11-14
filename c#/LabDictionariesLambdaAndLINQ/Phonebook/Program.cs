using System;
using System.Linq;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            List<string> input = Console.ReadLine().Split(' ').ToList();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    if (!phonebook.ContainsKey(input[1]))
                    {
                        phonebook.Add(input[1], (input[2]));
                    } else
                    {
                        phonebook[input[1]] = input[2];
                    }
                }
                else if (input[0] == "S")
                {
                    if (!phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var pair in phonebook.OrderBy(w =>w.Key))
                    {
                        Console.WriteLine("{0} -> {1}",pair.Key,pair.Value);
                    }
                }

                input = Console.ReadLine().Split(' ').ToList(); 
            }


        }
    }
}
