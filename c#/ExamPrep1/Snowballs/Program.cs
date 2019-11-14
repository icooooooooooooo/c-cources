using System;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            •	On the first line you will get the snowballSnow – an integer.
            •	On the second line you will get the snowballTime – an integer.
            •	On the third line you will get the snowballQuality – an integer.
            */
            int num = int.Parse(Console.ReadLine());

            double volMax = 0;
            int snowballSnowMax    = 0;
            int snowballTimeMax    = 0;
            int snowballQualityMax = 0;


            for (int i = 0; i < num; i++)
            {
                int snowballSnow    = int.Parse(Console.ReadLine());
                int snowballTime    = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                //(snowballSnow / snowballTime) ^ snowballQuality
                double snowballValue = Math.Pow((double)(snowballSnow / snowballTime), (double)snowballQuality);
                if (volMax<snowballValue)
                {
                    volMax = snowballValue;
                    snowballSnowMax = snowballSnow;
                    snowballTimeMax = snowballTime;
                    snowballQualityMax = snowballQuality;
                }
            }

            Console.WriteLine($"{snowballSnowMax} : {snowballTimeMax} = {volMax} ({snowballQualityMax})");
        }
    }
}
