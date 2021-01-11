using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Pds.Core.Logging;
using Pds.Shared.Audit.Api.Controllers;
using System.Threading.Tasks;

namespace Pds.Shared.Audit.Api.Tests.Integration
{
    [TestClass]
    public class AuditControllerTests
    {
        [TestMethod, TestCategory("Integration")]
        public async Task Get_ReturnsHelloResultFromExampleService()
        {
            // Arrange
            var expected = "Hello, world!";

            var logger = new Mock<ILoggerAdapter<AuditController>>();

            var controller = new AuditController(logger.Object);

            // Act
            var actual = await controller.Get();

            // Assert
            actual.Should().Be(expected);
        }
    }
}