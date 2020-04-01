using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        //Constructor
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
            numberOfBooks++;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }        

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            var index = 0;
            while(index < grades.Count)
            {
                result.Low = Math.Min(result.Low, grades[index]);
                result.High = Math.Max(result.High, grades[index]);
                result.Average+=grades[index];
                index++;
            }

            result.Average /= grades.Count;

            // calculate the Letter
            switch(result.Average)
            {
                case var d when d >= 90:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }
            
            return result;

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
            var stats = GetStatistics();

            System.Console.WriteLine($"Lowest grade: {stats.Low}");
            System.Console.WriteLine($"Highest grade: {stats.High}");
            System.Console.WriteLine($"Average grade: {stats.Average}");

        }

        static public void PrintNumberOfBooks()
        {
            System.Console.WriteLine($"You have instanciated {numberOfBooks} books !");
        }

        List<double> grades;
        public string Name;

        static int numberOfBooks = 0;
    }
    
}