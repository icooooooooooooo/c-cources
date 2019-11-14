using System;
using System.Linq;
using System.Collections.Generic;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> recources = new SortedDictionary<string, int>();

            List<string> input = Console.ReadLine().ToLower().Split(" ").ToList();

            int shards = 0;
            int fragments = 0;
            int motes = 0;

            recources.Add("shards", 0);
            recources.Add("fragments", 0);
            recources.Add("motes", 0);
            // Shards, Fragments and Motes 

            Dictionary<string, int> junk = new Dictionary<string, int>();

            while (shards < 250 && fragments < 250 && motes < 250)
            {
                for (int i = 1; i < input.Count; i+=2)
                {
                    if (!recources.ContainsKey(input[i]))
                    {
                        if (input[i] == "shards")
                        {
                            shards += int.Parse(input[i -1]);
                        }
                        else if (input[i] == "fragments")
                        {
                            fragments += int.Parse(input[i - 1]);
                        }
                        else if (input[i] == "motes")
                        {
                            motes += int.Parse(input[i - 1]);
                        }

                            recources.Add(input[i], int.Parse(input[i - 1]));
                    }
                    else
                    {
                        if (input[i] == "shards")
                        {
                            shards += int.Parse(input[i - 1]);
                        }
                        else if (input[i] == "fragments")
                        {
                            fragments += int.Parse(input[i - 1]);
                        }
                        else if (input[i] == "motes")
                        {
                            motes += int.Parse(input[i - 1]);
                        }

                        recources[input[i]] += int.Parse(input[i-1]);
                    }

                }
                input = Console.ReadLine().ToLower().Split(" ").ToList();
            }
         
            if (shards>=250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                recources["shards"] %= 250;
            }
            else if (fragments >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                recources["fragments"] %= 250;

            }
            else if (motes >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                recources["motes"] %= 250;

            }

            foreach (var recource in recources.OrderBy(x => x.Value))
            {
                Console.WriteLine("{0} -> {1}",recource.Key,recource.Value);
            }
        }
    }
}
