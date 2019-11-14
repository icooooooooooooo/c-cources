using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            string datasetToLookFor = Console.ReadLine();
            Dictionary<string, List<Dictionary<string,int>>> results = new Dictionary<string, List<Dictionary<string, int>>>();

            List<string> input = Console.ReadLine().Split(new string[] { "|", "->" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string dataset =string.Empty;
            string dataKey = string.Empty;
            int dataSize = 0;

            while (input[0]!= "thetinggoesskrra")
            {
                List<Dictionary<string, int>> listValue = new List<Dictionary<string, int>>();
                Dictionary<string, int> value = new Dictionary<string, int>();
                dataset = input[0].Trim();

                if (input.Count!=1)
                {
                    dataset = input[2].Trim();
                    dataKey = input[0];
                    dataSize = int.Parse(input[1]);

                    if (!results.ContainsKey(dataset))
                    {
                        value[dataKey] = dataSize;
                        listValue.Add(value);

                        results.Add(dataset, listValue);
                    }
                    else if (results.ContainsKey(dataset))
                    {
                        value[dataKey] = dataSize;
                        listValue.Add(value);

                        results[dataset].Add(value);
                    }
                }

                input = Console.ReadLine().Split(new string[] { "|", "->" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            int sum = 0;
            //Dictionary<string, List<Dictionary<string,int>>> - validate string keyvalue
            foreach (var result in results) //.Where(x=>x.Key==dataset)
            {
                //List<Dictionary<string,int>> - string key value is validated - go to the Value -> List 
                if (result.Key.Equals(dataset))
                {
                    for (int i = 0; i < result.Value.Count; i++)
                    {
                        foreach (var keys in result.Value[i])
                        {
                            sum += keys.Value;
                        }
                    }
                }
            }

            Console.WriteLine($"Data Set: {dataset}, Total Size: {sum}");

            foreach (var result in results.Where(x => x.Key == dataset))
            {
                for (int i = 0; i < result.Value.Count; i++)
                {
                    foreach (var keys in result.Value[i])
                    {
                        Console.WriteLine($"$.{keys.Key}");
                    }

                }
            }
           

            

        }
    }
}
