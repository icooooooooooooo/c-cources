using System;

namespace GreaterPfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            if (dataType == "int")
            {
                int input1 = int.Parse(Console.ReadLine());
                int input2 = int.Parse(Console.ReadLine());
                int biggerValue = BiggerValue(input1, input2);
                Console.WriteLine($"{biggerValue}");
            }
            else if (dataType == "char")
            {
                char input1 = Console.ReadLine()[0];
                char input2 = Console.ReadLine()[0];
                char biggerValue = BiggerValue(input1, input2);
                Console.WriteLine($"{biggerValue}");
            }
            else if (dataType == "string")
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                string biggerValue = BiggerValue(input1, input2);
                Console.WriteLine($"{biggerValue}");
            }
            else
            {
                Console.WriteLine("Unkown data type");
            }

            
            
        }

        static int BiggerValue(int i1,int i2)
        {
            int maxValue=0;
            if (i1 > i2)
            {
                maxValue = i1;
            }
            else if (i2 > i1)
            {
                maxValue = i2;
            } 
            return maxValue;
        }
        static char BiggerValue(char i1, char i2)
        {
            char maxChar = '0';
            if (i1 > i2)
            {
                maxChar = i1;
            }
            else if (i2 > i1)
            {
                maxChar = i2;
            }
            return maxChar;
        }
        static string BiggerValue(string i1, string i2)
        {
            string maxString = " ";
            int maxStringInNum = i1.CompareTo(i2);

            if (maxStringInNum>0)
            {
                maxString = i1;
            }
            else if (maxStringInNum<0)
            {
                maxString = i2;
            }
           // else
           // {
           //     maxString = "Same";
           // }
            return maxString;
        }


    }
}
