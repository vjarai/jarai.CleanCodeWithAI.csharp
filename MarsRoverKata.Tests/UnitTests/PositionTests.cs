using jarai.tdd7.MarsRoverKata;
using Xunit;

namespace MarsRoverKata.Tests.UnitTests;

public class PositionTests
{
    [Fact]
    public void EqualsTest()
    {
        // Arrange
        var pos1 = new Position(1, 2);
        var pos2 = new Position(1, 2);

        // Act
        bool actual = pos1.Equals(pos2);

        // Assert
        Assert.True(actual);
    }


    [Fact]
    public void overflow()
    {
        // Arrange
        var pos1 = new Position(4, 10);


        // Assert
        Assert.Equal(new Position(4, 0), pos1);
    }
}