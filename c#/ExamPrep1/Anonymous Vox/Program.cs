using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {

            var placeholderRegex = new Regex(@"([A-Za-z]+).+\1");
            var valueRegex = new Regex(@"{(.+?)}");

            string text = Console.ReadLine();
            string valuesText = Console.ReadLine();

            MatchCollection placeholders = placeholderRegex.Matches(text);
            MatchCollection values = valueRegex.Matches(valuesText);

            for (int i = 0; i < Math.Min(values.Count, placeholders.Count); i++)
            {
                Match placeholder = placeholders[i];
                string inject = values[i].Groups[1].Value;

                string replacement = $"{placeholder.Groups[1].Value}{inject}{placeholder.Groups[1].Value}";
                int startIndex = text.IndexOf(placeholder.Value);

                text = text.Substring(0, startIndex) + replacement + text.Substring(startIndex + placeholder.Length);
            }
            Console.WriteLine(text);

            // Regex inputReg = new Regex(@"([a-zA-Z]\S+[a-zA-Z]).+\1");
            // Regex replacementReg = new Regex(@"{(.+?)}");
            // 
            // string input = Console.ReadLine();
            // string replacements = Console.ReadLine();
            // 
            // MatchCollection inputTransform = inputReg.Matches(input);
            // MatchCollection replacementTransform = replacementReg.Matches(replacements);
            // 
            // for (int i = 0; i < Math.Min(inputTransform.Count,replacementTransform.Count); i++)
            // {
            //     var placeholder = inputTransform[i];
            //     string replacement =replacementTransform[i].Groups[1].Value;
            // 
            //     string replaced = $"{placeholder.Groups[1].Value}{replacement}{placeholder.Groups[1].Value}";
            //     int startIndex = input.IndexOf(placeholder.Value);
            // 
            //     input = input.Substring(0, startIndex) + replacement + input.Substring(startIndex + placeholder.Length);
            // 
            // }
            // Console.WriteLine(input);
        }
    }
}
