using System;

namespace ExactSumOfrealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumbers = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= nNumbers; i++)
            {
                decimal inputNum = decimal.Parse(Console.ReadLine());
                sum += inputNum;
            }
            Console.WriteLine(sum);
        }
    }
}
