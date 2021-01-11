using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Pds.Core.Logging;
using Pds.Shared.Audit.Api.Controllers;
using Pds.Shared.Audit.Services.Interfaces;
using System.Threading.Tasks;

namespace Pds.Shared.Audit.Api.Tests.Unit
{
    [TestClass]
    public class ExampleControllerTests
    {
        [TestMethod, TestCategory("Unit")]
        public async Task Get_ReturnsHelloResultFromExampleService()
        {
            // Arrange
            var expected = "Hello";

            var mockLogger = new Mock<ILoggerAdapter<AuditController>>();

            mockLogger
                .Setup(logger => logger.LogInformation(It.IsAny<string>()))
                .Verifiable();

         

            var controller = new AuditController(mockLogger.Object);

            // Act
            var actual = await controller.Get();

            // Assert
            actual.Should().Be(expected);
            mockLogger.Verify();
        }
    }
}