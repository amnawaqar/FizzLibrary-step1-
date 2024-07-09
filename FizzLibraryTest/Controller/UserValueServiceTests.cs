using FizzLibrary.Server.Controllers;
using FizzLibrary.Server.Model;
using FizzLibrary.Shared.Interface;
using FizzLibrary.Shared.Service;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace FizzLibraryTest.Controller
{
    public class UserValueServiceTests
    {


        private readonly Mock<IUserValue> _mockUserValue;
        private readonly UserController _controller;

        public UserValueServiceTests()
        {
            _mockUserValue = new Mock<IUserValue>();
            _controller = new UserController(_mockUserValue.Object);
        }

        [Fact]
        public void Save_ReturnsOkResult_WhenUserValueIsSaved()
        {
            // Arrange
            var userValueDto = new UserValueDto { Value = 2, UserId="test" };
            _mockUserValue.Setup(x => x.Save(userValueDto)).Returns(userValueDto);

            // Act
            var result = _controller.Save(userValueDto);

            // Assert
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            okResult.Value.Should().Be(userValueDto);
        }

        [Fact]
        public void Save_ReturnsBadRequest_WhenSavingFails()
        {
            // Arrange
            var userValueDto = new UserValueDto { Value = 4, UserId = "3" };
            UserValueDto expectedUserValue = null!;
            _mockUserValue.Setup(x => x.Save(userValueDto)).Returns(expectedUserValue);

            // Act
            var result = _controller.Save(userValueDto);

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Error saving the data", badRequestResult.Value);
        }

        [Fact]
        public void Save_ReturnsBadRequest_WhenUserValueDtoIsNull()
        {
            // Act
            var result = _controller.Save(null!);

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Invalid input data", badRequestResult.Value);
        }
    }
}
