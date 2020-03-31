using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        //Constructor
        public Book()
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void PrintGrades()
        {
            foreach(double grade in grades)
            {
                System.Console.WriteLine($"Bravo {grade}");
            }
        }

        List<double> grades;
    }
    
}