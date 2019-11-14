using System;

namespace Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            NewMethod(name);
        }

        private static void NewMethod(string name)
        {
            Console.WriteLine($"Hello {name}");
            return;
        }
    }
}
