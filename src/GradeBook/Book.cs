using System;
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
            numberOfBooks++;
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

        public void ShowStatistics()
        {
            double lowestGrade = double.MaxValue;
            double highestGrade = double.MinValue;
            double avgGrade = 0;

            foreach(double grade in grades)
            {
                lowestGrade = Math.Min(lowestGrade, grade);
                highestGrade = Math.Max(highestGrade, grade);
                avgGrade+=grade;
            }
            avgGrade /= grades.Count;

            System.Console.WriteLine($"Lowest grade: {lowestGrade}");
            System.Console.WriteLine($"Highest grade: {highestGrade}");
            System.Console.WriteLine($"Average grade: {avgGrade}");

        }

        static public void PrintNumberOfBooks()
        {
            System.Console.WriteLine($"You have instanciated {numberOfBooks} books !");
        }

        List<double> grades;
        string name;

        static int numberOfBooks = 0;
    }
    
}