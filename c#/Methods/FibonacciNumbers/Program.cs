using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nthFibonacciNumber = int.Parse(Console.ReadLine());

            int result = FibonacciNumbers(nthFibonacciNumber);
            Console.WriteLine($"{result}");
        }

        private static int FibonacciNumbers(int nthFibonacciNumber)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i <= nthFibonacciNumber; i++)
            {
                int temp = a;
                a = b;
                b = temp+b;
                //testing the sequence -- Console.WriteLine($"{a}");
            }
            return a;
        }
    }
}
