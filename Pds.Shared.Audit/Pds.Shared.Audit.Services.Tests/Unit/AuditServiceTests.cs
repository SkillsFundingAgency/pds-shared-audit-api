using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pds.Shared.Audit.Services.Implementations;
using System.Threading.Tasks;

namespace Pds.Shared.Audit.Services.Tests.Unit
{
    /// <summary>
    /// Audit service unit tests.
    /// </summary>
    [TestClass]
    public class AuditServiceTests
    {
        [TestMethod, TestCategory("Unit")]
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