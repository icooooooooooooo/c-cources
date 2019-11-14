using System;
using System.Linq;


namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string arrInText = Console.ReadLine();
            int[] arr = arrInText.Split(' ').Select(str => int.Parse(str)).ToArray();
            bool isTrippleSum = false;
            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = a+1; b < arr.Length; b++)
                {
                    for (int c = 0; c < arr.Length; c++)
                    {
                        if ((arr[a] + arr[b]) == arr[c])
                        {
                            Console.WriteLine($"{arr[a]} + {arr[b]} == {arr[c]}");
                            isTrippleSum = true;
                        }                        
                    }
                }
            }
            if (isTrippleSum == false)
            {
                Console.WriteLine("No");

            }
            
            // testing the array and code if all is, as expected

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //
            //}
            //Console.WriteLine()
        }
    }
}
