using jarai.tdd7.MarsRoverKata;
using Xunit;

namespace MarsRoverKata.Tests.UnitTests;

public class DirectionTests
{
    [Fact]
    public void Given_NorthDirection_when_TurnLeft_then_WestDirection()
    {
        // Arrange
        var sut = NorthDirection.Instance;

        // Act
        var actual = sut.TurnLeft();

        // Assert
        Assert.Equal(WestDirection.Instance, actual);
    }

    [Fact]
    public void Given_NorthDirection_when_TurnRight_then_EastDirection()
    {
        // Arrange
        var sut = NorthDirection.Instance;

        // Act
        var actual = sut.TurnRight();

        // Assert
        Assert.Equal(EastDirection.Instance, actual);
    }


    [Fact]
    public void Given_EastDirection_when_TurnLeft_then_NorthDirection()
    {
        // Arrange
        var sut = EastDirection.Instance;

        // Act
        var actual = sut.TurnLeft();

        // Assert
        Assert.Equal(NorthDirection.Instance, actual);
    }

    [Fact]
    public void Given_EastDirection_when_TurnRight_then_SouthDirection()
    {
        // Arrange
        var sut = EastDirection.Instance;

        // Act
        var actual = sut.TurnRight();

        // Assert
        Assert.Equal(SouthDirection.Instance, actual);
    }


    [Fact]
    public void Given_WestDirection_when_TurnLeft_then_SouthDirection()
    {
        // Arrange
        var sut = WestDirection.Instance;

        // Act
        var actual = sut.TurnLeft();

        // Assert
        Assert.Equal(SouthDirection.Instance, actual);
    }

    [Fact]
    public void Given_WestDirection_when_TurnRight_then_NorthDirection()
    {
        // Arrange
        var sut = WestDirection.Instance;

        // Act
        var actual = sut.TurnRight();

        // Assert
        Assert.Equal(NorthDirection.Instance, actual);
    }


    [Fact]
    public void Given_SouthDirection_when_TurnLeft_then_EastDirection()
    {
        // Arrange
        var sut = SouthDirection.Instance;

        // Act
        var actual = sut.TurnLeft();

        // Assert
        Assert.Equal(EastDirection.Instance, actual);
    }

    [Fact]
    public void Given_SouthDirection_when_TurnRight_then_WestDirection()
    {
        // Arrange
        var sut = SouthDirection.Instance;

        // Act
        var actual = sut.TurnRight();

        // Assert
        Assert.Equal(WestDirection.Instance, actual);
    }
}