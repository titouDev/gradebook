using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        //Constructor
        public Book(string name)
        {
            grades = new List<double>();
            // using this to avoid conflict with the name variable
            this.name = name;
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
        string name;
    }
    
}