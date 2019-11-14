using System;
using System.Linq;
using System.Collections.Generic;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugLocations = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] ladyMap = new int[fieldSize];

            for (int i = 0; i < ladybugLocations.Length; i++)
            {
                ladyMap[ladybugLocations[i]] = 1;
            }               
           
            List<string> command = Console.ReadLine().Split(' ').ToList();

            while(command[0] != "end")
            {
                int ladybugIndex = int.Parse(command[0]);
                int flyLength = int.Parse(command[2]);

                if (command[1] == "right")
                {
                    ladyMap[ladybugIndex] = 0;
                    LandingSpotPlus(ladyMap, ladybugIndex, flyLength);
                }
                else
                {
                    ladyMap[ladybugIndex] = 0;
                    LandingSpotMinus(ladyMap, ladybugIndex, flyLength);
                }
                command = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine(string.Join(' ', ladyMap));
        }

        private static void LandingSpotPlus(int[] ladyMap, int ladybugIndex, int flyLength)
        {
            int landingSpot = ladybugIndex + flyLength;

            if (landingSpot < ladyMap.Length && landingSpot >= 0)
            {
                if (ladyMap[landingSpot] != 0)
                {
                    flyLength += 1;
                    LandingSpotPlus(ladyMap,ladybugIndex,flyLength);
                }
                ladyMap[landingSpot] = 1;
            }
        }

        private static void LandingSpotMinus(int[] ladyMap, int ladybugIndex, int flyLength)
        {
            int landingSpot = ladybugIndex - flyLength;

            if (landingSpot < ladyMap.Length && landingSpot >= 0)
            {
                if (ladyMap[landingSpot] != 0)
                {
                    flyLength += 1;
                    LandingSpotMinus(ladyMap, ladybugIndex, flyLength);
                }
                ladyMap[landingSpot] = 1;
            }
        }
    }
}
