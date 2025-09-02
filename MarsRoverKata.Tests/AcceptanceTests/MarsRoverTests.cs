using jarai.tdd7.MarsRoverKata;
using Xunit;

namespace MarsRoverKata.Tests.AcceptanceTests;

public class MarsRoverTests
{
    [Fact]
    public void ExecuteCommands_M_should_0_1_N()
    {
        // Arrange
        var target = new MarsRover();

        // Act
        string actual = target.ExecuteCommands("M");

        // Assert

        Assert.Equal("0:1:N", actual);
    }


    [Fact]
    public void ExecuteCommands_MMMMMMMMMM_should_0_0_N()
    {
        // Arrange
        var target = new MarsRover();

        // Act
        string actual = target.ExecuteCommands("MMMMMMMMMM");

        // Assert
        Assert.Equal("0:0:N", actual);
    }

    [Fact]
    public void ExecuteCommands_MMRMMLM_should_2_3_N()
    {
        // Arrange
        var target = new MarsRover();

        // Act
        string actual = target.ExecuteCommands("MMRMMLM");

        // Assert
        Assert.Equal("2:3:N", actual);
    }

    [Fact]
    public void ExecuteCommands_MMMM_with_Obstacle_0_3_should_O_0_2_N()
    {
        // Arrange
        var grid = new Grid();
        grid.AddObstacle(new Position(0, 3));

        var target = new MarsRover(grid, new Position(0, 0), NorthDirection.Instance);

        // Act
        string actual = target.ExecuteCommands("MMMM");

        // Assert
        Assert.Equal("O:0:2:N", actual);
    }
}