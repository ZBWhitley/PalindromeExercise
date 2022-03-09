using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("house", false)]
        [InlineData("eye", true)]
        [InlineData("madam", true)]
        [InlineData("bird", false)]
        public void Test1(string word, bool expected)
        {
            //Arrange
            var WordSmith = new WordSmith();
            //Act
            var actual = WordSmith.IsAPalindrome(WordSmith);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
