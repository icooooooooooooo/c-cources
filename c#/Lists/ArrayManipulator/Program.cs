using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split(" ").ToList();

            while (commands[0]!="print")
            {
                switch (commands[0])
                {
                    case "add":
                        int index = int.Parse(commands[1]);
                        int element = int.Parse(commands[2]);
                        input.Insert(index, element);
                        break;

                    case "addMany":
                        index = int.Parse(commands[1]);
                        // commands.RemoveAt(1);
                        // commands.RemoveAt(0);
                        input.InsertRange(index, commands.Skip(2).Select(int.Parse));
                        /* 
                         * Here we could use the .Skip() method
                         */
                        break;

                    case "contains":
                        element = int.Parse(commands[1]);
                        if (input.Contains(element))
                        {
                            Console.WriteLine(input.IndexOf(element));
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }

                        break;

                    case "remove":
                        index = int.Parse(commands[1]);
                        input.RemoveAt(index);
                        break;

                    case "shift":
                        int positions = int.Parse(commands[1]);
                        if (positions > input.Count)
                        {
                            positions -= input.Count;
                        }

                        int tempHolder = 0;

                        for (int i = 0; i < positions; i++)
                        {
                            tempHolder = input[0];
                            for (int j = 1; j < input.Count; j++)
                            {
                                input[j - 1] = input[j];
                            }
                            input[input.Count - 1] = tempHolder;
                        }

                        break;

                    case "sumPairs":
                        List<int> helperList = new List<int>();
                        for (int i = 0; i < input.Count; i+=2)
                        {
                            if( i % 2 == 0)
                            {
                                if (i == input.Count-1)
                                {
                                    break;
                                }
                                else
                                {
                                    input[i] += input[i + 1];
                                    helperList.Add(input[i]);
                                }
                            }                          
                        }
                        
                        input.Clear();
                        input.AddRange(helperList);
                        helperList.Clear();                        
                        break;
                }


                commands = Console.ReadLine().Split(" ").ToList();
            }

            Console.WriteLine(string.Join(" ",input));
        }
    }
}
