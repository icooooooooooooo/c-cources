using System;

namespace TripleSum2
{
    class Program
    {
        static void Main(string[] args)
        {
            string integerText = Console.ReadLine();
            string[] textArrInt = integerText.Split(" ");
            int[] arr = new int[textArrInt.Length];

            for (int i = 0; i < textArrInt.Length; i++)
            {
                arr[i] = int.Parse(textArrInt[i]);
            }

            int length = arr.Length;
            bool isTrippleSumPossible = false;

            for (int a = 0; a < length; a++)
            {
                for (int b = 0; b < length; b++)
                {
                    for (int c = 0; c < length; c++)
                    {
                        if (a < b)
                        {
                            int sum = (arr[a] + arr[b]);
                            if (sum == arr[c])
                            {
                                isTrippleSumPossible = true;
                                Console.WriteLine($"{arr[a]} + {arr[b]} == {arr[c]}");
                            }

                        }
                    }
                }
            }

            if (isTrippleSumPossible == false)
            {
                Console.WriteLine($"No");
            }
        }
    }
}
