using System;

namespace CondenseArraytToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            string[] stringArray = stringInput.Split(' ');
            int[] arr = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++) 
            {
                arr[i] = int.Parse(stringArray[i]);
            }

            int lenght = arr.Length;
            if (lenght==1)
            {
                Console.WriteLine(arr[0]);
            }
            else { 

            int[] condensedArr = new int[arr.Length - 1];

                for (int j = 0; j < lenght - 1; j++)
                {

                    for (int i = 0; i < arr.Length - 1; i++)
                    {

                        condensedArr[i] = arr[i] + arr[i + 1];

                        arr[i] = condensedArr[i];

                    }
                    Console.WriteLine(arr[0]);
                }
            }
        }
    }
}
