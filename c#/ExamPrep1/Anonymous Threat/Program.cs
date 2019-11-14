using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<string> command = Console.ReadLine().Split(' ').ToList();


            List<string> output = new List<string>();

            while (command[0]!= "3:1")
            {
                

                if (command[0] == "merge")
                {
                    //validatinginput - could be a method, but it is used here only
                    int start = PlaceValidation(input, command);
                    int end = int.Parse(command[2]);
                    if (end > input.Count)
                    {
                        end = input.Count;
                    }
                    else if (end < 0)
                    {
                        end = 0;
                    }

                    //arraymanipulation
                    string merge = string.Empty;
                    for (int i = start; i < end; i++)
                    {
                        merge += input[i];
                    }
                    int count = 0;
                    for (int i = start; i < end; i++)
                    {
                        count++;
                    }

                    input.RemoveRange(start, count);
                    input.Insert(start, merge);
                }
                else if (command[0] == "divide")
                {
                    int start = PlaceValidation(input, command);
                    int dividePartitions = int.Parse(command[2]);

                    if (input[start].Length < dividePartitions)
                    {
                        dividePartitions = input[start].Length;
                    }
                    else if (dividePartitions < 1)
                    {
                        dividePartitions = 1;
                    }

                    int partitionLength = input[start].Length / dividePartitions;

                    var temp = new List<string>();

                    string partiton = string.Empty;
                    int counter = 0;
                    for (int i = 0; i < input[start].Length; i++)
                    {

                        if(counter<partitionLength-1)
                        {
                            counter++;
                            partiton += input[start][i].ToString();
                        }
                        else
                        {
                            partiton += input[start][i].ToString();
                            temp.Add(partiton);
                            partiton = string.Empty;
                            counter = 0;
                        }
                    }
                                
                    int divideLeft = input[start].Length % partitionLength;
                    if (divideLeft!=0)
                    {
                        temp[temp.Count - 2] = temp[temp.Count - 2] + temp[temp.Count-1];
                        temp.RemoveAt(temp.Count - 1);
                    }
                    input.RemoveAt(start);
                    input.InsertRange(start, temp);
                }
                command = Console.ReadLine().Split(' ').ToList();
            }


    Console.WriteLine(string.Join(' ',input));
        }

        private static int PlaceValidation(List<string> input, List<string> command)
        {
            int start = int.Parse(command[1]);
            if (start < 0)
            {
                start = 0;
            }
            else if (start > input.Count)
            {
                start = input.Count - 1;
            }

            return start;
        }
    }
}
