using System;
using System.Linq;
using System.Collections.Generic;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // "city|country|population"

            Dictionary<string,Dictionary<string,int>> demographics = new Dictionary<string, Dictionary<string, int>>();
            List<string> input = Console.ReadLine().Split("|").ToList();

            string country;
            string city;
            int population;

            while (input[0] != "report")
            { 
                country=input[1];
                city = input[0];
                population = int.Parse(input[2]);

                if (!demographics.ContainsKey(country))
                {
                    Dictionary<string, int> assist = new Dictionary<string, int>();
                    assist.Add(city, population);
                    demographics.Add(country, assist);
                }
                else
                {
                    if (!demographics[country].ContainsKey(city))
                    {
                        demographics[country].Add(city, population);
                    }
                    else
                    {
                        demographics[country][city] += population;
                    }
                }

                input = Console.ReadLine().Split("|").ToList();
            }

            foreach (var filedCountry in demographics)
            {
                int populationSum = 0;

                foreach (var cityfiled in filedCountry.Value)
                {
                    populationSum+=cityfiled.Value;
                }
                Console.WriteLine("{0} (total population: {1})", filedCountry.Key,populationSum);
                foreach (var cityfiled in filedCountry.Value)
                {
                    Console.WriteLine("=>{0}: {1}",cityfiled.Key,cityfiled.Value);
                }
            }
        }
    }
}
