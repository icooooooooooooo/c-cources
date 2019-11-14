using System;
using System.Linq;

namespace RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {

            string arrayInText = Console.ReadLine();
            double[] arr = arrayInText.Split(' ').Select(str => double.Parse(str)).ToArray();
            /*int[] arrInt = new int[arr.Length];
             * alternative
             */
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    arr[i] = Math.Ceiling(arr[i]);
                    Console.Write($"{arr[i]:f0} ");
                }
                else if (arr[i] < 0)
                {
                    arr[i] = Math.Floor(arr[i]);
                    Console.Write($"{arr[i]:f0} ");
                }
            }
            Console.WriteLine(" ");
        }
    }
}
