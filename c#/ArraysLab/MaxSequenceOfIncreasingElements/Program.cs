using System;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int counter = 1;
            int maxCounter = 0;
            int start = 0;    //last element of the sequence
            int maxStart = 0; //last element of the longest sequence 


            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]==arr[i-1]+1)
                {
                    counter++;
                    start = i;
                    if (i == arr.Length-1)
                    {
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            maxStart = start;
                        }
                    }
                } else if (arr[i] != arr[i - 1] + 1)
                {
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        counter = 1;
                        maxStart = start;
                    } else
                    {
                        counter = 1;
                        start = 0;
                    }
                }
            }

            for (int i = maxStart+1-maxCounter ; i < maxStart+1; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine(" ");
        }
    }
}
