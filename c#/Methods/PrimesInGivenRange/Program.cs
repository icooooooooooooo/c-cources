using System;

namespace PrimeCheckerInMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            long bottom = long.Parse(Console.ReadLine());
            long top = long.Parse(Console.ReadLine());


            NumberInput(bottom,top);
        }

        private static void NumberInput(long bottom, long top)
        {
            long num; //declare the variable
            for ( num = bottom; num <= top; num++)
            {
                Console.WriteLine($"{num}");
                IsPrime(num);
            }

        }

        static void IsPrime(long num)
        {
            bool isPrime = false;
            for (long i = 2; i < num; i++)
            {
                //if (i == 0)
                //{
                //    isPrime = false;
                //    //Console.WriteLine($"{num} false");
                //}
                //else if (i==1)
                //{
                //    isPrime = false;
                //    //Console.WriteLine($"{num} false");
                //}
                if (num == 2)
                {
                    isPrime = true;
                }
                else if (num % i == 0)
                {
                    isPrime = false;
                    //Console.WriteLine($"{num} false");                    
                }
                else
                {
                    isPrime = true;
                }
               
            }
            if (isPrime)
            {
                Console.WriteLine($"{num} true ");
            }

        }
    }
}
