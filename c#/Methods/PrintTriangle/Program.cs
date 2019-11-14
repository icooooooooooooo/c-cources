using System;

namespace PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int columns = int.Parse(Console.ReadLine());
            PrintTriangle(columns);
        }

        static void PrintTriangle(int columns)
        {
            for (int row = 1; row <= columns; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write($"{column}");
                }
                Console.WriteLine("");
            }
            for (int row = columns - 1; row >= 1; row--)
            {
                for (int column = row; column >= 1; column--)
                {
                    Console.Write($"{column}");
                }
                Console.WriteLine("");
            }
        }
    }
}
