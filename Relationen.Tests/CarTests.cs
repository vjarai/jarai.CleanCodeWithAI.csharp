using Moq;
using Relationen;
using Xunit;

namespace Relationen.Tests
{
    public class CarTests
    {
        [Fact]
        public void Drive_ShouldStartAndStopEngine()
        {
            // Arrange
            var mockEngine = new Mock<Engine>(100) { CallBase = true };
            var car = new Car("TestMake", "TestModel", mockEngine.Object);

            // Act
            car.Drive(10);

            // Assert
            mockEngine.Verify(e => e.Start(), Times.Once);
            mockEngine.Verify(e => e.Stop(), Times.Once);
        }
    }
}