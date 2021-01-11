using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pds.Shared.Audit.Services.Implementations;
using System.Threading.Tasks;

namespace Pds.Shared.Audit.Services.Tests.Integration
{
    [TestClass]
    [TestCategory("Integration")]
    public class AuditServiceTests
    {
        [TestMethod]
        public async Task Hello_ReturnsExpectedResult()
        {
            // Arrange
            var expected = "Hello, world!";

            var auditService = new AuditService();

            // Act
            var actual = await auditService.Hello();

            // Assert
            actual.Should().Be(expected);
        }
    }
}