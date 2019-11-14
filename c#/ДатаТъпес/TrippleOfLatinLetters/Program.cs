using System;

namespace TrippleOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97 + n ; i++)
            {
                for (int j = 97; j < 97 + n; j++)
                {
                    for (int k = 97; k < 97 + n; k++)
                    {                       
                        if (i <= j && j <= k)
                        Console.WriteLine($"{(char)(i)}{(char)(j)}{(char)(k)}");
                    }
                }
            }
        }
    }
}
