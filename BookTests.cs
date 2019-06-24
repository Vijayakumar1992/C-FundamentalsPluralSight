using System;
using Xunit;


//HOW TO UNIT TEST THE PROJECT
namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact] // attribute - little piece of data attached to method test1
        public void Test1()
        {
            // //arrange 
            // var x = 5;
            // var y = 2;
            // var expected = 7;
            // //act
            // var actual = x + y;            
            // //assert
            // Assert.Equal(expected, actual);

            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            //act -- arrange the date to act on 
            var result = book.GetStatistics();

            //asserts
            Assert.Equal(85.7, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.5, result.Low, 1);
        }
    }
}
