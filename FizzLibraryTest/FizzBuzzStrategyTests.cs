using FizzLibrary.Shared.Interface;
using FizzLibrary.Shared.Service;
using FluentAssertions;
using Moq;

namespace FizzLibraryTest
{
    public class FizzBuzzStrategyTests
    {
        [Theory]
        [InlineData(9, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz" })]
        [InlineData(5, new[] { "1", "2", "fizz", "4", "buzz" })]
        [InlineData(15, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizzbuzz" })]
        public void GenerateFizzBuzz_ShouldReturnCorrectSequence(int number, string[] expected)
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzStrategy();

            // Act
            var result = fizzBuzzService.GenerateFizzBuzz(number);

            // Assert
            result.Should().Equal(expected);
        }

    }
}