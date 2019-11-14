using System;

namespace MultiplyEvensSumByOddsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = MultiplyEvensSumByOddsSum(number);

            Console.WriteLine($"{result}");
        }

        private static int MultiplyEvensSumByOddsSum(int number)
        {
            int num = Math.Abs(number);
            int oddSum = 0;
            int evenSum = 0;
            int counter = 0;

            while (num > 0)
            {
                counter++;
                int lastDigit = num % 10;
                if (counter % 2 != 0)
                {
                    oddSum += lastDigit;
                }
                else
                {
                    evenSum += lastDigit;
                }
                num /= 10;

            }

            return oddSum * evenSum;
        }
        //static int EvenSum(int num)
        //{
        //    return;
        //}

    }
}
