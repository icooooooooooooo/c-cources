using System;

namespace Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int contestants = int.Parse(Console.ReadLine());
            int averageLaps = int.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            float money = float.Parse(Console.ReadLine());

            int maxrunners = trackCapacity * days;
            if (contestants > maxrunners)
            {
                contestants = maxrunners;
            }
            int totalLaps = contestants * averageLaps;
            float totalDistance = totalLaps * trackLength / 1000;
            float moneyRaised = totalDistance * money;

            Console.WriteLine($"{moneyRaised:f2}");
   /*         
Money raised by kilometer = 3
Money raised for the marathon = 40 * 3 = 120 
*/

        }
    }
}
