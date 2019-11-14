using System;
using System.Linq;
using System.Collections.Generic;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split(' ').ToList();

            while(command[0] != "Odd" && command[0] != "Even")
            {
                if (command[0]=="Delete")
                {
                    numbers.RemoveAll(num => num==int.Parse(command[1])); 
                }
                else if (command[0]=="Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    numbers.Insert(position,element);
                }
                
                command = Console.ReadLine().Split(' ').ToList();
            }

            if (command[0] == "Odd")
            {
                numbers.RemoveAll(odd => odd % 2 == 0);
            }
            else if (command[0] == "Even")
            {
                numbers.RemoveAll(even => even % 2 == 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

