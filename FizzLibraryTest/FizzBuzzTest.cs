using FizzLibrary.Shared.Service;
using FluentAssertions;

namespace FizzLibraryTest
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(9, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz" })]
        [InlineData(5, new[] { "1", "2", "fizz", "4", "buzz" })]
        [InlineData(15, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizzbuzz" })]
        public void GenerateFizzBuzz_ShouldReturnCorrectSequence(int number, string[] expected)
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzService();

            // Act
            var result = fizzBuzzService.GenerateFizzBuzz(number);

            // Assert
            result.Should().Equal(expected);
        }
        [Fact]
        public void GenerateFizzBuzz_WithZero_ShouldReturnEmpty()
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzService();

            // Act
            var result = fizzBuzzService.GenerateFizzBuzz(0);

            // Assert
            result.Should().BeEmpty();
        }

        [Fact]
        public void GenerateFizzBuzz_WithNegativeNumber_ShouldReturnEmpty()
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzService();

            // Act
            var result = fizzBuzzService.GenerateFizzBuzz(-5);

            // Assert
            result.Should().BeEmpty();
        }
        [Fact]
        public void GenerateFizzBuzz_WithNumberGreaterThan1000_ShouldReturnEmpty()
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzService();

            // Act
            var result = fizzBuzzService.GenerateFizzBuzz(2001);

            // Assert
            result.Should().BeEmpty();
        }

    }
}