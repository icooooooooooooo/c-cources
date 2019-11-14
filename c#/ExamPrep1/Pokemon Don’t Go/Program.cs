using System;
using System.Linq;
using System.Collections.Generic;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distance = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sumRem = 0;
            var answerSequence = new List<int>(); 
            int index = int.Parse(Console.ReadLine());

            while (distance.Count>1)
            {
                int number;
                if (index<0)
                {
                    number = distance[0];
                    sumRem += number;
                    distance[0]=distance[distance.Count];
                    /*If the given index is LESS than 0, 
                    * remove the first element of the sequence, 
                    * and COPY the last element to its place. 
                    */
                    Manipulator(distance, number);

                }
                else if (index > distance.Count-1)
                {
                    number = distance[distance.Count - 1];
                    sumRem += number;
                    distance[distance.Count-1] = distance[0];
                    /* If the given index is GREATER than the last index of the sequence, 
                    * remove the last element from the sequence, 
                    * and COPY the first element to its place.
                    */
                    Manipulator(distance, number);

                }
                else
                {
                    number = distance[index];
                    sumRem += number;
                    distance.RemoveAt(index);
                    Manipulator(distance, number);
                }
                Console.WriteLine(string.Join(' ', distance));
                answerSequence.Add(number);
                
                index = int.Parse(Console.ReadLine());
            }

            sumRem += distance[0];
            answerSequence.Add(distance[0]);

            Console.WriteLine(string.Join('+', answerSequence));

            Console.WriteLine(sumRem);
        }

        public static void Manipulator(List<int> distance, int number)
        {
            for (int i = 0; i < distance.Count; i++)
            {
                if (distance[i] <= number)
                {
                    distance[i] += number;
                }
                else
                {
                    distance[i] -= number;
                }
            }
        }
    }
}
