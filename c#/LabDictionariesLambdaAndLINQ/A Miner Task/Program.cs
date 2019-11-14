using System;
using System.Linq;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> metals = new Dictionary<string, int>();

            string input = Console.ReadLine();
            int quantity;

            while (input != "stop")
            {
                quantity = int.Parse(Console.ReadLine());
                if (!metals.ContainsKey(input))
                {
                    metals.Add(input, quantity);
                }else
                {
                    metals[input] += quantity;
                }
                input = Console.ReadLine();
            }

            foreach (var metal in metals)
            {
                Console.WriteLine("{0} -> {1}",metal.Key,metal.Value);

            }
        }
    }
}
