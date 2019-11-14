using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());

            LongestDiagonal(x1, y1, x2, y2, x3, y3, x4, y4);


        }

        private static void LongestDiagonal(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            int side1 = (Math.Abs(x1) + Math.Abs(x2));
            int side2 = (Math.Abs(y1) + Math.Abs(y2));
            double diagonal1 = Math.Sqrt(side1 * side1 + side2 * side2);

            int side3 = (Math.Abs(x3) + Math.Abs(x4));
            int side4 = (Math.Abs(y3) + Math.Abs(y4));
            double diagonal2 = Math.Sqrt(side3 * side3 + side4 * side4);



            //test Console.WriteLine(Math.Min(diagonal1, diagonal2));

            if (diagonal1 >= diagonal2)
            {
                Console.WriteLine(ComputinEngine(x1, y1, x2, y2));
            } else
            {
                Console.WriteLine(ComputinEngine(x3, y3, x4, y4));
            }
        }

        private static string ComputinEngine(int x1, int y1, int x2, int y2)
        {
            double pair1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double pair2 = Math.Sqrt(x2 * x2 + y2 * y2);

            double closest = Math.Min(pair1, pair2);

            // the below is returning a string, as this is the only thing I was able to think of on how toreturn the two digits from this method only. 
            if (pair1 <= pair2)
            {
                string answer = ((x1.ToString()) + " " + (y1.ToString()) +" " + (x2.ToString()) + " " + (y2.ToString()));
                return (answer);
            }
            else
            {
                string answer = ((x2.ToString()) + " " + (y2.ToString()) + " " + (x1.ToString()) + " " + (y1.ToString()));

                return (answer);
            }
        }
    }
}
