using jarai.tdd7.MarsRoverKata;
using Xunit;

namespace MarsRoverKata.Tests.UnitTests;

public class MarsRoverTest
{
    [Fact]
    public void Given_new_MarsRover_when_MoveForward_then_postion_0_1()
    {
        // Arrange
        var target = new MarsRover();

        // Act
        var actual = target.MoveForward();

        // Assert
        Assert.Equal(new Position(0, 1), actual);
    }

    [Fact]
    public void Given_new_MarsRover_when_TurnLeft_then_direction_west()
    {
        // Arrange
        var target = new MarsRover();

        // Act
        string actual = target.TurnLeft();

        // Assert
        Assert.Equal("W", actual);
    }


    [Fact]
    public void Given_new_MarsRover_when_TurnRight_then_direction_east()
    {
        // Arrange
        var target = new MarsRover();

        // Act
        string actual = target.TurnRight();

        // Assert
        Assert.Equal("E", actual);
    }
}