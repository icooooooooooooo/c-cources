using System;

namespace PrimeCheckerInMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberInput = long.Parse(Console.ReadLine());

            Console.WriteLine($"{IsPrime(numberInput)}");
        }

        private static bool IsPrime(long num)
        {
            bool isPrime = false;
            for (long i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                } else
                {
                    isPrime = true;
                    break;
                }

            }

            return isPrime;
        }
    }
}
