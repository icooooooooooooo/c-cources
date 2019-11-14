using System;
using System.Linq;
using System.Collections.Generic;

namespace Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            
            while (snowmen.Count>1)
            {
                var indexesToRemove = new List<int>();

                for (int i = 0; i < snowmen.Count; i++)
                {
                    if (snowmen.Count(x => x != -1)==1)
                    {
                        break;
                    }

                    if (snowmen[i] == -1)
                    {
                        continue;
                    }

                    int attacker = i;
                    int target = snowmen[i] % snowmen.Count;

                    int diff =  Math.Abs(attacker - target);
                    //note to self - do not overcomplicate and read the problem thurly 
                   

                    if (attacker==target)
                    {
                        snowmen[attacker] = -1;
                        Console.WriteLine($"{attacker} performed harakiri");
                        indexesToRemove.Add(attacker);                       
                    }
                    else if (diff % 2 == 0)
                    {
                        int yes = int.Parse("1");
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        snowmen[target] = -1;
                        indexesToRemove.Add(target);
                    }
                    else
                    { 
                        snowmen[attacker] = -1;
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        indexesToRemove.Add(attacker);
                    }
                }
                snowmen = snowmen
                    .Where(x => x != -1)
                    .ToList();

            }
        }
    }
}
