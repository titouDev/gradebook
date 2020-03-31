using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(89.1);
            book.AddGrade(15.2);
            book.AddGrade(8.31);

            book.PrintGrades();

            double[] numbers = new double[3] {12.5, 10.48, 20};
            // same as                     
            // var numbers = new[] {12.5, 10.48, 20};
            double result = 0;

            foreach(double number in numbers)
            {
                result += number;
            }
            System.Console.WriteLine(result);

            List<double> grades = new List<double>();
            grades.Add(15);
            grades.Add(12);
            grades.Add(11.5);
            result = 0;
            
            foreach(double n in grades)
            {
                result += n;
            }
            result /= grades.Count;
            // using N1 for formatting
            System.Console.WriteLine($"Your grade is {result:N1}");

            if(args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello !");
            }
        }
    }
}
