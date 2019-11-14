using System;
using System.Collections.Generic;
using System.Text;

namespace IntersectionOfCircles
{
    class Circle
    {
        Point reference = new Point();
        public Point Center { get; set; }
        public double Radius { get; set; }

        public bool isIntersected(Circle circle)
        {
            double distance = Math.Sqrt((circle.Center.X -Center.X)* (circle.Center.X - Center.X) + (circle.Center.Y - Center.Y)* (circle.Center.Y - Center.Y));

            if (distance >= circle.Radius + Radius)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
