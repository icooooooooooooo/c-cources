using System;
using System.Linq;
using System.Collections.Generic;

namespace RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            // left, top, width, height

            List<Rectangle> list = new List<Rectangle>();

            Rectangle fig1 = ReadRectangle() ;
            Rectangle fig2 = ReadRectangle();

            list.Add(fig1);
            list.Add(fig2);

            bool isInside = InsideOrNot(fig1,fig2);

            if (isInside == true)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }

        }

        private static bool InsideOrNot(Rectangle r1, Rectangle r2)
        {
            bool result;
            int r1Right = r1.left + r1.width;
            int r2Right = r2.left + r2.width;

            int r1Bottom = r1.top + r1.height;
            int r2Bottom = r2.top + r2.height;
            
            if (r1.left >= r2.left && r1Right <= r2Right && r1.top <= r2.top && r1Bottom <= r2Bottom)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        private static Rectangle ReadRectangle()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            Rectangle figure = new Rectangle
            {
                left = int.Parse(input[0]),
                top = int.Parse(input[1]),
                width = int.Parse(input[2]),
                height = int.Parse(input[3])
            };
            
            return figure;
        }
    }
}
