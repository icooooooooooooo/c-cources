using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peope = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine((int)Math.Ceiling((double)peope/(double)capacity));
        }
    }
}
