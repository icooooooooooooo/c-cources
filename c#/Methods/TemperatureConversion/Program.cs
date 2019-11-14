using System;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double farenheit = double.Parse(Console.ReadLine());
            double celsius = TemperatureConversion(farenheit);

            Console.WriteLine($"{celsius:f2}");
        }

        static double TemperatureConversion(double inputTemp)
        {
            return (inputTemp - 32) * 5 / 9;
        }

    }
}
