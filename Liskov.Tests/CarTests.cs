using Moq;
using Xunit;

namespace Liskov.Tests;

public class CarTests
{
    [Fact]
    public void Drive_ShouldStartAndStopEngine()
    {
        // Arrange
        var mockEngine = new Mock<Engine>(100) { CallBase = true };

        //var car = new Car("TestMake", "TestModel", mockEngine.Object);

        // Liskov: Eine abgeleitete Klasse muss �berall dort eingesetzt werden k�nnen, wo die Basisklasse erwartet wird.
        var car = new Cabrio("TestMake", "TestModel", mockEngine.Object);

        // Act
        car.Drive(10);

        // Assert
        mockEngine.Verify(e => e.Start(), Times.Once);
        mockEngine.Verify(e => e.Stop(), Times.Once);
    }
}