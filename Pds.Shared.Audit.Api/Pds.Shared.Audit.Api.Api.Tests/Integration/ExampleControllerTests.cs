using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Pds.Core.Logging;
using Pds.Shared.Audit.Api.Api.Controllers;
using Pds.Shared.Audit.Api.Services.Implementations;
using System.Threading.Tasks;

namespace Pds.Shared.Audit.Api.Api.Tests.Integration
{
    [TestClass]
    public class ExampleControllerTests
    {
        [TestMethod, TestCategory("Integration")]
        public async Task Get_ReturnsHelloResultFromExampleService()
        {
            // Arrange
            var expected = "Hello, world!";

            var logger = new Mock<ILoggerAdapter<ExampleController>>();
            var exampleService = new ExampleService();

            var controller = new ExampleController(logger.Object, exampleService);

            // Act
            var actual = await controller.Get();

            // Assert
            actual.Should().Be(expected);
        }
    }
}