using System;
using Xunit;

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
            book.ShowStatistics();
        }
    }
}
