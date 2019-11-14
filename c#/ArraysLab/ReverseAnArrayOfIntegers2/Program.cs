using System;

namespace ReverseAnArrayOfIntegers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = length - 1; i >= 0; i--)
            {
            Console.WriteLine(arr[i]);
            }
        }
    }
}
