using System;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Border(number);
            Middle(number);
            Middle(number);
            Border(number);
        }

        static void Border(int num)
        {

            Console.WriteLine(new string('-', 2*num));
            return;
        }

        static void Middle(int num)
        {
            Console.Write("-");

            for (int i = 1; i <= num; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine("-");

            return;
        }
    }
}
