using System;
using System.Linq;
using System.Collections.Generic;

namespace IntersectionOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray(); //reading the input
            double[] input2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray(); //reading the input

            Point center1 = new Point();
            Circle c1 = new Circle();

            c1.Center = new Point();
            c1.Center.X = input1[0];
            c1.Center.Y = input1[1];
            c1.Radius = input1[2];

            Point center2 = new Point();
            Circle c2 = new Circle();

            c2.Center = new Point();
            c2.Center.X = input2[0];
            c2.Center.Y = input2[1];
            c2.Radius = input2[2];

            bool result = c1.isIntersected(c2);
            bool result2 = Intersects(c1, c2);

            if (result == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool Intersects(Circle c1, Circle c2)
        {
        
            return true;
        }
    }
}
