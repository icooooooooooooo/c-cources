using System;

namespace PrimeCheckerInMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            long bottom = long.Parse(Console.ReadLine());
            long top = long.Parse(Console.ReadLine());
            ValidatePrime(bottom, top);
        }

        private static void ValidatePrime(long bottom, long top)
        {
            for (long i = bottom; i <= top; i++)
            {
                IsPrime(i);
                //Console.WriteLine($"{i}");
            }
        }

        private static void IsPrime(long num)
        {                       
            int counter = 0;

            for (long i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    counter++;
                }
            }

            if (counter == 2)
            {
                Console.WriteLine($"{num}");                       
            }
        }
    }
}