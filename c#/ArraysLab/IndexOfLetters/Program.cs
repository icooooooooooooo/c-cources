using System;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] abc = new char[26];
            int length = abc.Length;

            for (int i = 0; i < abc.Length; i++)
            {                
                    abc[i] = (char)(97+i);                
            }
                       
            string input = Console.ReadLine();

            char[] stringToChar = input.ToCharArray();

            for (int i = 0; i < stringToChar.Length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (stringToChar[i] == abc[j])
                    {
                        Console.WriteLine($"{stringToChar[i]} -> {j}");
                    }
                }
            }

//            Console.WriteLine();
        }
    }
}
