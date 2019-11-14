using System;

namespace DayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNum = int.Parse(Console.ReadLine());
            string[] weekDays = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            if (dayNum > 0 && dayNum <= 7)
            {
                Console.WriteLine($"{ weekDays[dayNum-1] }");
            }
            else
            {
            Console.WriteLine("Invalid Day!");
            }
        }
    }
}
