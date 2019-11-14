using System;

namespace NumberInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            MirrorNumber(inputNumber);

        }

        static void MirrorNumber(double num)
        {
            string numInText= num.ToString();
            string reversedNumInText = "";
            int length = num.ToString().Length;
            //for (int i = 1; i <= length; i++)
            //{
                // correct for int only double lastDigit = (int)(num % 10);
                // correct for int only reversedNumInText += lastDigit;
                // correct for int only num /= 10;
                for (int place = length-1 ; place >=0; place--)
                {
                    char symbol = numInText[place];
                    // not working, as array needs to be a specific number and not a variable  --  char[place] symbol = numInText.ToCharArray();
                    reversedNumInText += symbol;
                    // for testing purpouces Console.WriteLine($"{reversedNumInText}");
                }
            //}
            double reversedNumber = double.Parse(reversedNumInText);
            Console.WriteLine($"{reversedNumber}");
        }
}
}
