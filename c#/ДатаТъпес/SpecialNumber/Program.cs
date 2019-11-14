using System;

namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLimit = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nLimit; i++)
            {
                int digitSum = 0;
                digitSum += i % 10;
                digitSum += i / 10;

                bool isSpecial = false;
                if (digitSum==5|| digitSum == 7|| digitSum == 11)
                {
                    isSpecial = true;
                }
            Console.WriteLine($"{i} -> {isSpecial}");

            }
        }
    }
}
