using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> testClass = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student person = new Student();
                List<string> input = Console.ReadLine().Split(' ').ToList();
                person.Name = input[0];
                input.RemoveAt(0);
                person.Grade = input.Select(double.Parse).ToList();
                testClass.Add(person);
            }

            foreach (var person in testClass.Where(x => x.AverageGrade>=5).OrderBy(x=>x.Name).ThenByDescending(x=>x.AverageGrade))
            {
                Console.WriteLine($"{person.Name}-> {person.AverageGrade:f2}");
            }

        }
    }
}
