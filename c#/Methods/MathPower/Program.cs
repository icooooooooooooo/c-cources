using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            int result = MathPower(number,power);
            Console.WriteLine($"{result}");
        }

        static int MathPower(int n, int p)
        {
            int temp = n;
            int result = temp;
            for (int i = 1; i < p; i++)
            {
                result *= n;
            }
            return (result);
        }
    }
}
