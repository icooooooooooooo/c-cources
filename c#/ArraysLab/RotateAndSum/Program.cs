using System;
using System.Linq; //not used

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] numInString = text.Split(" ");
            int[] arr = new int[numInString.Length];

            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(numInString[i]);
            }
            /* 
             * converting the text into an array via for cycle - faster code
             */
            int rotations = int.Parse(Console.ReadLine());
            int tempHolder = 0;

            int[] tempArr = new int[length];
            int[] sumArr = new int[length];

            tempHolder = arr[length - 1];

            for (int i = 0; i < rotations; i++)
            {

                for (int j = 1; j < length; j++)
                {
                    if (i == 0)
                    {
                        tempArr[j] = arr[j - 1];
                        sumArr[j] += tempArr[j];
                    }
                    else if (i >= 1)
                    {
                        tempArr[j] = arr[j - 1];
                        sumArr[j] += tempArr[j];
                    }
                }
                tempArr[0] = tempHolder;
                sumArr[0] += tempArr[0];
                tempHolder = tempArr[length - 1];
                for (int j = 0; j < length; j++)
                {
                    arr[j] = tempArr[j];
                }
            }

            Result(length, sumArr);
        }

        private static void Result(int length, int[] sumArr)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{sumArr[i]} ");
            }
            Console.WriteLine(" ");
        }
    }
}
