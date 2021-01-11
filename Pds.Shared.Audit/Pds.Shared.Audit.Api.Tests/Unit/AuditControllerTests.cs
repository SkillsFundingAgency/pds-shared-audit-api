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
    public class AuditControllerTests
    {
        [TestMethod, TestCategory("Unit")]
        public async Task Get_ReturnsHelloResultFromAuditService()
        {
            // Arrange
            var expected = "Hello";

            var mockLogger = new Mock<ILoggerAdapter<AuditController>>();

            mockLogger
                .Setup(logger => logger.LogInformation(It.IsAny<string>()))
                .Verifiable();

            var mockAuditService = new Mock<IAuditService>();

            mockAuditService
                .Setup(e => e.Hello())
                .ReturnsAsync(expected)
                .Verifiable();

            var controller = new AuditController(mockLogger.Object, mockAuditService.Object);

            // Act
            var actual = await controller.Get();

            // Assert
            actual.Should().Be(expected);
            mockLogger.Verify();
            mockAuditService.Verify();
        }
    }
}