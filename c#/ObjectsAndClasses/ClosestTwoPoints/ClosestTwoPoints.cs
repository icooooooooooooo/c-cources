using System;
using System.Linq;
using System.Collections.Generic;

namespace ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program to read n points and find the closest two of them

            int n = int.Parse(Console.ReadLine());

            /* 
             * 3 4
             * 6 8
             * 2 5
             * -1 3
             */
            List<Point> list = new List<Point>();
            

            for (int i = 1; i <= n; i++)
            {
                //List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

                Point input = ReadPoint();

                list.Add(input);

            }

            double closestPair = 1500.00;

            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n ; j++)
                {
                    Point p1 = list[i];
                    Point p2 = list[j];

                    var dist = DistCalc(p1,p2);
                    

                    if (dist < closestPair)
                    {
                        closestPair = dist;
                    }
                }
            }

            // Point pointname = new Point { X = int.Parse(Console.ReadLine()), Y = int.Parse(Console.ReadLine()) };
                                 
            Console.WriteLine(closestPair);
        }

        static Point ReadPoint()
        {

            var pointResult = Console.ReadLine().Split(' ');

            Point point = new Point
            {
                X = int.Parse(pointResult[0]),
                Y = int.Parse(pointResult[1])
            };

            return point;
        }

        static double DistCalc(Point p1, Point p2)
        {
            var sideX = p1.X - p2.X;
            var sideY = p1.Y - p2.Y;

            double distPow = sideX * sideX + sideY * sideY;
            double dist = Math.Sqrt(distPow);
                       
            return dist;
        }

    }
}
