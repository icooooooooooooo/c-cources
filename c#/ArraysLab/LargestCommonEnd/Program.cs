using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ').ToArray();
            string[] input2 = Console.ReadLine().Split(' ').ToArray();

            int length = Math.Min(input1.Length, input2.Length);
            int countLeft = 0;
            int countRight = 0;

           // bool isLeftGreater = false;
           // bool isRightGreater = false;

            for (int i = 0; i < length; i++)
            {
                if (input2[i]==input1[i])
                {
                    countLeft++;
                }
                else
                {
                    break;
                }
            }

            for (int j = length - 1; j >= 0; j--)
            {
                if (input2[j] == input1[j])
                {
                    countRight++;
                } else
                {
                    break;
                }
            }

            if (countLeft > countRight)
            {
                //isLeftGreater = true;
                Console.Write("The largest common end is at the left: ");
                for (int i = 0; i < countLeft; i++)
                {
                    Console.Write($"{input1[i]} ");
                }

            }
            else if (countLeft < countRight)
            {
                // isRightGreater = true;
                Console.Write("The largest common end is at the right: ");
                for (int i = 0; i < countRight; i++)
                {
                    Console.Write($"{input1[length-i]} ");
                }
            }
            else
            {
                Console.WriteLine("No common words at the left and right!");
            }
        }
    }
}
