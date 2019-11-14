using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int counter = 1;
            int counterMax = 1;
            int num = 0;
            int numMax = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    num = arr[i - 1];
                    counter++;
                    if (counter == arr.Length)
                    {
                        counterMax=counter;
                        numMax = num;

                    }
                } else if (arr[i] != arr[i - 1])
                {
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        counter = 1;
                        numMax = num;
                    } else
                    {
                        counter = 1;
                    }
                }
            }

            for (int i = 0; i < counterMax; i++)
            {
                Console.Write(numMax + " ");
            }
        }
    }
}
