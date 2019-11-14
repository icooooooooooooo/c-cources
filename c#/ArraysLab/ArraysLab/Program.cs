using System;

namespace ArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int weekday = int.Parse(Console.ReadLine());

            string[] dayOfTheWeek = new string[7]{"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};


            if (weekday > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine($"{dayOfTheWeek[weekday - 1]}");
            }
        }
    }
}
