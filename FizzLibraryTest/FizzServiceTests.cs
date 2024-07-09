using FizzLibrary.Shared.Service;
using FluentAssertions;
using System;
using System.Collections.Generic;

namespace FizzLibraryTest
{
    public class FizzServiceTests
    {
        [Theory]
        [InlineData(9, "fizz")]
        public void WhenNumberIsDivisbleBy3_ShouldReturnFizz(int number, string expected)
        {
            // Arrange
            var fizzService = new FizzService();

            // Act
            var result = fizzService.GenerateFizzBuzz(number);

            // Assert
            result.Should().Equals(expected);
        }
        [Theory]
        [InlineData(8, "")]
        public void WhenNumberIsNotDivisbleBy3_ShouldReturnEmptyString(int number, string expected)
        {
            // Arrange
            var fizzService = new FizzService();

            // Act
            var result = fizzService.GenerateFizzBuzz(number);

            // Assert
            result.Should().Equals(expected);
        }
    }
}
