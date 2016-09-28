using StackOverflow.Models;
using Xunit;

namespace StackOverflow.Tests
{
    public class ItemTest
    {
        [Fact]
        public void GetTitleTest()
        {
            //Arrange
            var question = new Question();
            question.Title = "Wash the dog?";

            //Act
            var result = question.Title;

            //Assert
            Assert.Equal("Wash the dog?", result);
        }
    }
}