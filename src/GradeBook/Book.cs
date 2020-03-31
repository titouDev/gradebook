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

        static public void PrintNumberOfBooks()
        {
            System.Console.WriteLine($"You have instanciated {numberOfBooks} books !");
        }

        List<double> grades;
        string name;

        static int numberOfBooks = 0;
    }
    
}