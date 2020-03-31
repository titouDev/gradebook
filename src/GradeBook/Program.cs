using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("My New Book");
            book.AddGrade(89.1);
            book.AddGrade(15.2);
            book.AddGrade(8.31);            
            
            book.ShowStatistics();

            Book.PrintNumberOfBooks();

        }
    }
}
