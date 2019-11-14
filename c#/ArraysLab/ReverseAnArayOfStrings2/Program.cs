using System;

namespace ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();
            string[] arr = array.Split(' ');
            string temp; //declare temp


            for (int i = 0; i < arr.Length/2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length-i-1] = temp;

                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine(" ");
        }
    }
}
