using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<List<string>> numbersInText = Console.ReadLine()
                .Split('|')
                .Reverse()
                .Select(s => s.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList())
                .ToList();

            foreach (var innerList in numbersInText)
            {
                
                    Console.Write(string.Join(" ", innerList)+ " ");
                
            }



            for (int i = 0; i < numbersInText.Count; i++)
            {
                Console.WriteLine(numbersInText[i]);
            }
        }
    }
}
