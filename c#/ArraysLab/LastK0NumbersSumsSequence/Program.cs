using System;

namespace LastK0NumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] sequence = new int[n];
            sequence[0] = 1;
            // int sum=0;

            for (int i = 1; i < n; i++)
            {
                // i=4 j=4-
                for (int j = i-1 ; j>i-1-k ; j--)
                {

                    if (j >= 0)
                    {
                        sequence[i] += sequence[j];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{sequence[i]} ");
            }

        }
    }
}
