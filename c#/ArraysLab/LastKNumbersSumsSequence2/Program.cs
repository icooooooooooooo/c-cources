using System;

namespace LastKNumbersSumsSequence2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int kPrevElements = int.Parse(Console.ReadLine());

            int[] arr = new int[length];
            arr[0] = 1;

            for (int i = 1; i < length; i++)
            {
                for (int j = i-1 ;  i-kPrevElements <= j ; j--)
                {
                    if (j >= 0)
                    {
                        arr[i] += arr[j];
                    }
                }
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
