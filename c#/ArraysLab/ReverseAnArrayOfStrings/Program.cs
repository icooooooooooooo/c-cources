using System;

namespace ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();
            string[] arr = array.Split(' ');

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");                
            }
            Console.WriteLine(" ");
        }
    }
}
