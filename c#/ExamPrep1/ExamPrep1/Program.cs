using System;

namespace ExamPrep1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            decimal halfPower = (decimal)pokePower / 2;
            int distance = int.Parse(Console.ReadLine());
            int powReduce = int.Parse(Console.ReadLine());

            int countTargets = 0;

            while (pokePower!=0)
            {
                if (pokePower >= distance)
                {
                    if (pokePower>halfPower)
                    {
                        pokePower -= distance;
                        countTargets++;
                    }
                    else
                    {
                        pokePower /= powReduce;
                        if (pokePower - distance >= 0)
                        {
                            pokePower -= distance;
                            countTargets++;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(pokePower + "\n" + countTargets);
        }
    }
}
