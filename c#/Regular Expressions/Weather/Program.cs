using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Regex r1 = new Regex(@"([A-Z]{2})([0-9]{2}\.[0-9]{1,2})(?i)(sunny|rainy|cloudy)"); //(?i) stands for case insencitive in regex 

            Dictionary<string,weather> data = new Dictionary<string, weather>();
            string name = string.Empty;
            while (command != "end")
            {
                Match match = r1.Match(command);
                if (r1.IsMatch(command))
                {
                    name = match.Groups[1].Value;
                    weather temp = new weather(name);
                    if (!data.ContainsKey(name))
                    {
                        temp.City = (match.Groups[1].Value); // this one is not really necessary, as the name is already the Key of the dictionary
                        temp.Temperature = double.Parse(match.Groups[2].Value);
                        temp.Weather = (match.Groups[3].Value);

                        data.Add(name, temp); 
                    }
                    else
                    {
                        temp.City = (match.Groups[1].Value); // this one is not really necessary, as the name is already the Key of the dictionary
                        temp.Temperature = double.Parse(match.Groups[2].Value);
                        temp.Weather = (match.Groups[3].Value);

                        data[name] = temp;
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var city in data)
            {
                Console.WriteLine($"{city.Key.ToUpper()} => {city.Value.Temperature:f2} => {city.Value.Weather.ToLower()}");
            }
        }
    }        
}   
