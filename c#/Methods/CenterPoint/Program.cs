using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine(ComputinEngine(x1, y1, x2, y2));

        }

        private static string ComputinEngine(double x1, double y1, double x2, double y2)
        {
            double pair1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double pair2 = Math.Sqrt(x2 * x2 + y2 * y2);

            double closest = Math.Min(pair1, pair2);


            // the below is returning a string, as this is the only thing I was able to think of on how toreturn the two digits from this method only. 
            if (pair1 <= pair2)
            {
                string answer = (x1.ToString()) + " " + (y1.ToString());
                return (answer);
            } else
            {
                string answer = (x2.ToString()) + " " + (y2.ToString());
                return (answer);
            }
        }
    }
}
