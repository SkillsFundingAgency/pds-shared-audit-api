using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Pds.Core.Logging;
using Pds.Shared.Audit.Api.Controllers;
using Pds.Shared.Audit.Services.Implementations;
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
            var exampleService = new AuditService();

            var controller = new AuditController(logger.Object, exampleService);

            // Act
            var actual = await controller.Get();

            // Assert
            actual.Should().Be(expected);
        }
    }
}