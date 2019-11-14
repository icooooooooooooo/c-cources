using System;
using System.Linq;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int[] arr1 = input1.Split(' ').Select(str => int.Parse(str)).ToArray();
            int[] arr2 = input2.Split(' ').Select(str => int.Parse(str)).ToArray();


            int lenght1 = arr1.Length;
            int lenght2 = arr2.Length;

            int[] arrShort = new int[Math.Max(lenght1, lenght2)];

            int[] arrResult = new int[Math.Max(lenght1, lenght2)];

            for (int i = 0; i < Math.Max(lenght1,lenght2); i++)
            {
                if (lenght1>lenght2 )
                {                  
                    for (int j = 0; j < Math.Max(lenght1, lenght2); j++)
                    {
                        
                        arrShort[j] = arr2[j%lenght2];

                        arrResult[j] = arr1[j] + arrShort[j];

                    }

                }else if (lenght2>lenght1)
                {
                    for (int j = 0; j < Math.Max(lenght1, lenght2); j++)
                    {

                        arrShort[j] = arr1[j % lenght1];

                        arrResult[j] = arr2[j] + arrShort[j];

                    }
                }
                else
                {
                    arrResult[i] = arr1[i] + arr2[i];
                }
                Console.Write(arrResult[i] + " ");

            }
            Console.WriteLine(" ");

        }
    }
}
