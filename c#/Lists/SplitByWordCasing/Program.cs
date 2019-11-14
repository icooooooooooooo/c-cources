using System;
using System.Linq;
using System.Collections.Generic;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split(",;:.!()\"'\\/[] ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            List<string> Upper = new List<string>();
            List<string> Lower = new List<string>();
            List<string> Mixed = new List<string>();

            int[] statusArr = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                if (IsUpper(words[i]))
                {
                    Upper.Add(words[i]);
                } else if (IsLower(words[i]))
                {
                    Lower.Add(words[i]);
                } else
                {
                    Mixed.Add(words[i]);
                }                
            }

            Console.WriteLine(string.Join(", ", Upper));
            Console.WriteLine(string.Join(", ", Lower));
            Console.WriteLine(string.Join(", ", Mixed));
        }

        static bool IsUpper(string word)
        {
            char[] arr = word.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<'A' || arr[i] > 'Z')
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsLower(string word)
        {
            char[] arr = word.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 'a' || arr[i] > 'z')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
