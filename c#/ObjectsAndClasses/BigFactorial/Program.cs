using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = int.Parse(Console.ReadLine());

            BigInteger number = 1;

            for (int i = 1; i <= factorial; i++)
            {
                number *= i;
            }
            Console.WriteLine(number);
        }
    }
}
