using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookGetStatisticsMethod()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(85);
            book.AddGrade(95);
            book.AddGrade(91);
            
            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(90.3, result.Average, 1);
            Assert.Equal(85, result.Low, 1);
            Assert.Equal(95, result.High, 1);
            Assert.Equal('A', result.Letter);

        }
    }
}
