using System;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = TriangleArea(height,width);
            Console.WriteLine($"{area}");
        }

        static double TriangleArea(double h, double w)
        {
            return (h * w / 2);
        }
    }
}
