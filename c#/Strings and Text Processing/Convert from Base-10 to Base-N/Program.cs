using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int target = arr[0];
            BigInteger numberToConvert = arr[1];

            StringBuilder result = new StringBuilder();
            BigInteger remain = 0;

            while(numberToConvert!=0)
            {
                remain = numberToConvert % target;
                numberToConvert /= target;
                result.Append(remain.ToString());                
            }
            var end = result.ToString().ToCharArray().Reverse();


            Console.WriteLine(string.Join("",end));
        }
    }
}
