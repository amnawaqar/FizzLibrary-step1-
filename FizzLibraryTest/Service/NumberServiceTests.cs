using FizzLibrary.Shared.Service;
using FluentAssertions;

namespace FizzLibraryTest.Service
{
    public class NumberServiceTests
    {
        [Theory]
        [InlineData(5, "5")]
        public void WhenNumberIsNotDivisibleby5And3_ShouldReturnNumberAsString(int number, string expected)
        {
            // Arrange
            var NumberService = new NumberService();

            // Act
            var result = NumberService.GenerateFizzBuzz(number);

            // Assert
            result.Should().Equals(expected);
        }
        [Theory]
        [InlineData(15, "")]
        public void WhenNumberIsDivisibleby5And3_ShouldReturnEmptyString(int number, string expected)
        {
            // Arrange
            var NumberService = new NumberService();

            // Act
            var result = NumberService.GenerateFizzBuzz(number);

            // Assert
            result.Should().Equals(expected);
        }
    }
}
