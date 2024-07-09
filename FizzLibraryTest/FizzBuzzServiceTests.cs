using FizzLibrary.Shared.Service;
using FluentAssertions;
using System;
namespace FizzLibraryTest
{
    public class FizzBuzzServiceTests
    {
        [Theory]
        [InlineData(15, "fizzbuzz")]
        public void WhenNumberIsDivisibleby5And3_ShouldReturnFizzBuzz(int number, string expected)
        {
            // Arrange
            var FizzBuzzService = new FizzBuzzService();

            // Act
            var result = FizzBuzzService.GenerateFizzBuzz(number);

            // Assert
            result.Should().Equals(expected);
        }
        [Theory]
        [InlineData(5, "")]
        public void WhenNumberIsNotDivisibleby5And3_ShouldReturnEmptyString(int number, string expected)
        {
            // Arrange
            var FizzBuzzService = new FizzBuzzService();

            // Act
            var result = FizzBuzzService.GenerateFizzBuzz(number);

            // Assert
            result.Should().Equals(expected);
        }
    }
}
