using FizzLibrary.Shared.Interface;
using FizzLibrary.Shared.Service;
using FluentAssertions;
using Moq;

namespace FizzLibraryTest
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(9)]
        public void WhenNumberIsDivisibleBy3_ShouldReturnFizz(int number)
        {
            //Arrange
            var mockNumberChecker = new FizzBuzzService();

            // Act
            var result = mockNumberChecker.NumberIsDivisibleBy3(number);

            // Assert
            result.Should().Be("fizz");
        }
        [Theory]
        [InlineData(5)]
        public void WhenNumberIsNotDivisibleBy3_ShouldReturnEmptyString(int number)
        {
            //Arrange
            var mockNumberChecker = new FizzBuzzService();

            // Act
            var result = mockNumberChecker.NumberIsDivisibleBy3(number);

            // Assert
            result.Should().Be("");
        }
        [Theory]
        [InlineData(10)]
        public void WhenNumberIsDivisibleBy5_ShouldReturnBuzz(int number)
        {
            //Arrange
            var mockNumberChecker = new FizzBuzzService();

            // Act
            var result = mockNumberChecker.NumberIsDivisibleBy5(number);

            // Assert
            result.Should().Be("buzz");
        }
        [Theory]
        [InlineData(4)]
        public void WhenNumberIsNotDivisibleBy5_ShouldReturnEmptyString(int number)
        {
            //Arrange
            var mockNumberChecker = new FizzBuzzService();

            // Act
            var result = mockNumberChecker.NumberIsDivisibleBy5(number);

            // Assert
            result.Should().Be("");
        }
        [Theory]
        [InlineData(15)]
        public void WhenNumberIsDivisibleBy3And5_ShouldReturnFizzBuzz(int number)
        {
            //Arrange
            var mockNumberChecker = new FizzBuzzService();

            // Act
            var result = mockNumberChecker.NumberIsDivisibleBy3And5(number);

            // Assert
            result.Should().Be("fizzbuzz");
        }
        [Theory]
        [InlineData(5)]
        public void WhenNumberIsNotDivisibleBy3And5_ShouldReturnEmptyString(int number)
        {
            //Arrange
            var mockNumberChecker = new FizzBuzzService();

            // Act
            var result = mockNumberChecker.NumberIsDivisibleBy3And5(number);

            // Assert
            result.Should().Be("");
        }
        [Theory]
        [InlineData(5, new[] { 1, 2, 3, 4, 5 })]
        public void ReturnVerticalList_ShouldReturnListWithValuesUpToGivenNumber(int number, int[] expectedList)
        {
            // Arrange
            var numberService = new FizzBuzzService();

            // Act
            var resultList = numberService.ReturnVerticalList(number);

            // Assert
            resultList.Should().Equal(expectedList);
        }
        //step2

    }
}