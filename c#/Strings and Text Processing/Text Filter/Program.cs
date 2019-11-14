using System;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine();
            var input = Console.ReadLine();

            string replaced = input.Replace("Windows", "*******");
            replaced = input.Replace("Linux", "*****");

            Console.WriteLine(replaced);
        }
    }
}
