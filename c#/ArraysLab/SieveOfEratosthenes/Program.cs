using System;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine())+1;
            bool[] allNum = new bool[limit];
            for (int i = 2; i < limit; i++)
            {
                allNum[i] = true;
            }

            for (int i = 2; i < limit; i++)
            {
                if (allNum[i]==true)
                for (int j = 2; j < limit; j++)
                {
                        if (i * j < limit)
                        {
                            allNum[i * j] = false;
                        } else
                        {
                            break;
                        }
                }
            }

            for (int i = 2; i < limit; i++)
            {
                if (allNum[i]==true)
                Console.Write($"{i} ");
            }
            Console.WriteLine(" ");
        }
    }
}
