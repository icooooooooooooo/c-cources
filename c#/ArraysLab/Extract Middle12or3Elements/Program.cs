using System;

namespace Extract_Middle12or3Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string arrString = Console.ReadLine();
            string[] stringArr = arrString.Split(' ');
            int[] arr = new int[stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                arr[i] = int.Parse(stringArr[i]);
            }
            int lenght = arr.Length;

            if (lenght == 1)
            {
                Console.WriteLine($"{{ {arr[0]} }}");
            }else if (lenght % 2 == 0)
            {
                int midpoint = (lenght / 2)-1;
                Console.WriteLine($"{{ {arr[midpoint]}, {arr[midpoint+1]} }}");

            }
            else
            {
                int midpoint = lenght / 2;
                Console.WriteLine($"{{ {arr[midpoint-1]}, {arr[midpoint]}, {arr[midpoint + 1]} }}");


            }
        }
    }
}
