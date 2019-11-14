using System;
using System.Linq;
using System.Collections.Generic;

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a method to calculate the distance between two points 
             * p1 {x1, y1} and 
             * p2 {x2, y2}. 
             * Write a program to read two points (given as two integers) 
             * and print the Euclidean distance between them.
             */

            //  var point1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            //  var point2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Point p1 = new Point { X = int.Parse(Console.ReadLine()), Y = int.Parse(Console.ReadLine()) };
            Point p2 = new Point { X = int.Parse(Console.ReadLine()), Y = int.Parse(Console.ReadLine()) };



            Console.WriteLine($"{DistanceBetweenPoints(p1.X,p1.Y,p2.X, p2.Y):f3}");
        }

        public static double DistanceBetweenPoints(int x1, int y1, int x2, int y2 )
        {
            // int x1 = point1[0];
            // int y1 = point1[1];
            // 
            // int x2 = point2[0];
            // int y2 = point2[1];

            double xDiff = Math.Abs( x1 - x2 );
            double yDiff = Math.Abs( y1 - y2 );

            double calc = xDiff * xDiff + yDiff * yDiff;
            double dist = Math.Sqrt(calc);


            return dist;
        }
    }
}
