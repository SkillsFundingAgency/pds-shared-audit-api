using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pds.Shared.Audit.Api.Services.Implementations;
using System.Threading.Tasks;

namespace Pds.Shared.Audit.Api.Services.Tests.Unit
{
    [TestClass]
    public class ExampleServiceTests
    {
        [TestMethod, TestCategory("Unit")]
        public async Task Hello_ReturnsExpectedResult()
        {
            // Arrange
            var expected = "Hello, world!";

            var exampleService = new ExampleService();

            // Act
            var actual = await exampleService.Hello();

            // Assert
            actual.Should().Be(expected);
        }
    }
}