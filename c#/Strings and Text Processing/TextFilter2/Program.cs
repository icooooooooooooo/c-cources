using System;

namespace TextFilter2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(new char[] {',', ' '},StringSplitOptions.RemoveEmptyEntries);

            var input = Console.ReadLine();
            foreach (var word in bannedWords)
            {
                string replacement = new string('*', word.Length);
                input=input.Replace(word, replacement);
            }

            Console.WriteLine(input);
        }
    }
}
