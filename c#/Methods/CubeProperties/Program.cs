using System;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            string task = Console.ReadLine();

            CubeCalculator(task,side);

        }

        private static void CubeCalculator(string task, int side)
        {
            double result = 0; //declaring the variable

            switch (task)
            {
                case "face diagonals":
                    result = FaceDiagonals(side);
                    break;
                case "space diagonals":
                    result = SpaceDiagonal(side);
                    break;
                case "volume":
                    result = Volume(side);
                    break;
                case "surface area":
                    result = SurfaceArea(side);
                    break;
            }
            Console.WriteLine($"{result:f2}");
        }

        private static int SurfaceArea(int side)
        {
            return side * side * 6;
        }

        private static int Volume(int side)
        {
            return side * side * side;
        }

        private static double SpaceDiagonal(int side)
        {
            return Math.Sqrt(FaceDiagonals(side) * FaceDiagonals(side) + side * side);
        }

        private static double FaceDiagonals(int side)
        {
            return Math.Sqrt(side * side + side * side);
        }
    }
}
