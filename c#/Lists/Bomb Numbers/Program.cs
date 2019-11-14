using System;
using System.Linq;
using System.Collections.Generic;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> commands = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int bombID = commands[0];
            int shockWave = commands[1];

            int length = numbers.Count;

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == bombID)
                {
                    if (i + shockWave >= numbers.Count)
                    {
                        int diff = Math.Abs(i + shockWave - numbers.Count);

                        while(numbers.Count<=length+diff)
                        {
                            numbers.Add(1);
                        }

                        Explosion(numbers, shockWave, i);

                    }
                    else if (i - shockWave < 0)
                    {
                        int diff = Math.Abs(i + shockWave - numbers.Count);

                        while (numbers.Count <= length + diff)
                        {
                            numbers.Insert(0,1);
                        }

                        Explosion(numbers, shockWave, i);
                    }
                    else
                    {
                        Explosion(numbers, shockWave, i);
                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }

        private static void Explosion(List<int> numbers, int shockWave, int i)
        {
            for (int j = i + shockWave; j >= i - shockWave; j--)
            {
                numbers.RemoveAt(j);
            }
        }
    }
}
