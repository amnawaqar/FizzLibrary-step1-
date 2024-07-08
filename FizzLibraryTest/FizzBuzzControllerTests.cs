using FizzLibrary.Server.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using FizzLibrary.Shared.Interface;
using FluentAssertions;

namespace FizzLibraryTest
{
    public class FizzBuzzControllerTests
    {
        private readonly Mock<IFizzBuzz> _mockFizzBuzzService;
        private readonly FizzBuzzController _controller;

        public FizzBuzzControllerTests()
        {
            _mockFizzBuzzService = new Mock<IFizzBuzz>();
            _controller = new FizzBuzzController(_mockFizzBuzzService.Object);
        }

        [Theory]
        [InlineData(9, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz" })]
        public void GenerateFizzBuzz_ValidNumber_ShouldReturnOkResult(int number, string[] expected)
        {
            // Arrange
            _mockFizzBuzzService.Setup(service => service.GenerateFizzBuzz(number)).Returns(new List<string>(expected));

            // Act
            var result = _controller.GenerateFizzBuzz(number);

            // Assert
            var okResult = result as OkObjectResult;
            okResult.Should().NotBeNull();
            okResult.Value.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(-1)]
        public void GenerateFizzBuzz_InvalidNumber_ShouldReturnBadRequest(int number)
        {
            // Act
            var result = _controller.GenerateFizzBuzz(number);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            badRequestResult.Should().NotBeNull();

            badRequestResult.Value.Should().Be("Number must be should between 1 and 1000.");
        }
    }
}
