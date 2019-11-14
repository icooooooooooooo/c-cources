using System;
using System.Collections.Generic;

namespace _4Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] {' ',',','.','!','?' },StringSplitOptions.RemoveEmptyEntries);

            List<string> isPalindrome = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string reversed = Reversed(input[i]).ToString();

                if (input[i] == reversed)
                {
                    isPalindrome.Add(reversed);
                }
            }
            Console.WriteLine(string.Join(", ",isPalindrome));

        }

        public static string Reversed(string v)
        {
            var reversing = v.ToCharArray();
            var resultArr = new char[reversing.Length];

            for (int i = 0; i < reversing.Length; i++)
            {
                resultArr[i] = reversing[reversing.Length-1-i];
            }

            string result= new string(resultArr);

            return result;
        }
    }
}
