using FizzLibrary.Server.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using FizzLibrary.Shared.Interface;
using FluentAssertions;
using FizzLibrary.Shared.Service;

namespace FizzLibraryTest
{
    public class FizzBuzzControllerTests
    {
        private readonly FizzBuzzController _controller;
        private readonly FizzBuzzStrategy _fizzBuzzStrategy;

        public FizzBuzzControllerTests()
        {
            _fizzBuzzStrategy = new FizzBuzzStrategy();
            _controller = new FizzBuzzController(_fizzBuzzStrategy);
        }

        [Theory]
        [InlineData(9, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz" })]
        public void GenerateFizzBuzz_ShouldReturnOk(int number, string[] expected)
        {
            // Act
            var result = _controller.GenerateFizzBuzz(number);

            // Assert
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            okResult.Value.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        public void GenerateFizzBuzz_ShouldReturnBadRequest_WhenNumberIsLessThanOne(int number)
        {
            // Act
            var result = _controller.GenerateFizzBuzz(number);

            // Assert
            var badRequestResult = result.Should().BeOfType<BadRequestObjectResult>().Subject;
            badRequestResult.Value.Should().Be("Number must be between 1 and 1000.");
        }
        [Theory]
        [InlineData(2000)]
        public void GenerateFizzBuzz_ShouldReturnBadRequest_WhenNumberIsGreaterThan1000(int number)
        {
            // Act
            var result = _controller.GenerateFizzBuzz(number);

            // Assert
            var badRequestResult = result.Should().BeOfType<BadRequestObjectResult>().Subject;
            badRequestResult.Value.Should().Be("Number must be between 1 and 1000.");
        }
    }
}
