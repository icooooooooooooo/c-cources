using System;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            NewMethod(input);
        }

        private static void NewMethod(int input)
        {
            int lastDigit = input % 10;
            string number = " ";
            switch (lastDigit)
            {
                case 0:
                    number = "zero";
                    break;
                case 1:
                    number = "one";
                    break;
                case 2:
                    number = "two";
                    break;
                case 3:
                    number = "three";
                    break;
                case 4:
                    number = "four";
                    break;
                case 5:
                    number = "five";
                    break;
                case 6:
                    number = "six";
                    break;
                case 7:
                    number = "seven";
                    break;
                case 8:
                    number = "eight";
                    break;
                case 9:
                    number = "nine";
                    break;
            }
                Console.WriteLine($"{number}");
            return;

        }
    }
}
