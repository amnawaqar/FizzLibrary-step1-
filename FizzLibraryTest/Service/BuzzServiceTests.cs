using FizzLibrary.Shared.Service;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzLibraryTest.Service
{
    public class BuzzServiceTests
    {
        [Theory]
        [InlineData(5, "buzz")]
        public void WhenNumberIsDivisbleBy5_ShouldReturnBuzz(int number, string expected)
        {
            // Arrange
            var buzzService = new FizzService();

            // Act
            var result = buzzService.GenerateFizzBuzz(number);

            // Assert
            result.Should().Equals(expected);
        }
        [Theory]
        [InlineData(8, "")]
        public void WhenNumberIsNotDivisbleBy5_ShouldReturnEmptyString(int number, string expected)
        {
            // Arrange
            var BuzzService = new BuzzService();

            // Act
            var result = BuzzService.GenerateFizzBuzz(number);

            // Assert
            result.Should().Equals(expected);
        }
    }
}
