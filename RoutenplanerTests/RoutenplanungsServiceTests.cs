using Xunit;
using Routenplaner;
using Moq;

namespace Routenplaner.Tests
{
    public class RoutenplanungsServiceTests
    {
        [Fact]
        public void PlaneRoute_DelegatesToStrategy_ReturnsExpectedResult()
        {
            // Arrange
            var mockStrategie = new Mock<IRoutenStrategie>();
            mockStrategie.Setup(s => s.PlaneRoute("A", "B")).Returns("Dummy: A -> B");
            var service = new RoutenplanungsService(mockStrategie.Object);

            // Act
            var result = service.PlaneRoute("A", "B");

            // Assert
            Assert.Equal("Dummy: A -> B", result);
            mockStrategie.Verify(s => s.PlaneRoute("A", "B"), Times.Once);
        }

        [Fact]
        public void PlaneRoute_WithAutoRoutenStrategie_ReturnsAutoRoute()
        {
            // Arrange
            var strategie = new AutoRoutenStrategie();
            var service = new RoutenplanungsService(strategie);

            // Act
            var result = service.PlaneRoute("Berlin", "Hamburg");

            // Assert
            Assert.Equal("Route von Berlin nach Hamburg mit dem Auto geplant.", result);
        }

        [Fact]
        public void PlaneRoute_WithFahrradRoutenStrategie_ReturnsFahrradRoute()
        {
            // Arrange
            var strategie = new FahrradRoutenStrategie();
            var service = new RoutenplanungsService(strategie);

            // Act
            var result = service.PlaneRoute("München", "Augsburg");

            // Assert
            Assert.Equal("Route von München nach Augsburg mit dem Fahrrad geplant.", result);
        }

        [Fact]
        public void PlaneRoute_WithBahnRoutenStrategie_ReturnsBahnRoute()
        {
            // Arrange
            var strategie = new BahnRoutenStrategie();
            var service = new RoutenplanungsService(strategie);

            // Act
            var result = service.PlaneRoute("Köln", "Düsseldorf");

            // Assert
            Assert.Equal("Route von Köln nach Düsseldorf mit der Bahn geplant.", result);
        }
    }
}