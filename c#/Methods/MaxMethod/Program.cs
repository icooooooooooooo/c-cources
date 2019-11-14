using System;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int numC = int.Parse(Console.ReadLine());

            GetMax(numA, numB, numC);
        }

        static void GetMax(int a, int b, int c)
        {
            int max = Math.Max(a, b);
            max = Math.Max(max, c);

            Console.WriteLine($"{max}");


        }
    }

}
