using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(15.21);
            book.AddGrade(1.21);
            book.AddGrade(16.5);
            
            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(11, result.Average, 1);
            Assert.Equal(1.21, result.Low, 1);
            Assert.Equal(16.5, result.High, 1);

        }
    }
}
