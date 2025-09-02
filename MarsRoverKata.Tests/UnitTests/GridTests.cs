using jarai.tdd7.MarsRoverKata;
using Xunit;

namespace MarsRoverKata.Tests.UnitTests;

public class GridTests
{
    [Fact]
    public void Given_grid_with_obstacle_at_0_0_then_grid_HasObstacle_at_0_0()
    {
        // Arrange
        var target = new Grid();
        target.AddObstacle(new Position(0, 0));

        // Act
        bool actual = target.HasObstacle(new Position(0, 0));

        // Assert
        Assert.True(actual);
    }
}