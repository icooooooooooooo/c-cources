using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grade { get; set; }
        public double AverageGrade { get { return Grade.Average(); } }
    }
}
