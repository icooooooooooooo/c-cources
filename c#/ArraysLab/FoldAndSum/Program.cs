using System;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string[] textToArray = inputText.Split(" ");
            int[] arr = new int[textToArray.Length];
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(textToArray[i]);
            }
            /*----------------------------------------------------
             * Converting Text into Integer Array
             *----------------------------------------------------
             */

            int q = length / 4; //q==quarter

            //First half:
            int[] topArr = new int[2*q];
            for (int i = 0; i < q; i++)
            {
                topArr[i] = arr[q - i - 1];
                topArr[q+i] = arr[4 * q - i - 1];
            }


            //Second Half
            int[] bottomArr = new int[2 * q];

            for (int i = 0; i < 2*q; i++)
            {
                bottomArr[i] = arr[q + i];
            }


            //Folded Array
            int[] foldedArr = new int[2 * q];

            for (int i = 0; i < 2*q; i++)
            {
                foldedArr[i] = topArr[i] + bottomArr[i];
                Console.Write($"{foldedArr[i]} ");
            }
        }
    }
}
