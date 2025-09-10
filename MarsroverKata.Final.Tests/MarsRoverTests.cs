namespace MarsroverKata.Final.Tests
{
    public class MarsRoverTests
    {
        [Fact]
        public void ExecuteCommands_NoObstacles_MMRMMLM_Returns_2_3_N()
        {
            // Arrange
            var grid = new Grid(10, 10); // 10x10 grid, no obstacles
            var rover = new MarsRover(grid);

            // Act
            var result = rover.ExecuteCommands("MMRMMLM");

            // Assert
            Assert.Equal("2:3:N", result);
        }
        [Fact]
        public void ExecuteCommands_NoObstacles_M_Returns_0_1_N()
        {
            // Arrange
            var grid = new Grid(10, 10); // 10x10 grid, no obstacles
            var rover = new MarsRover(grid);

            // Act
            var result = rover.ExecuteCommands("M");

            // Assert
            Assert.Equal("0:1:N", result);
        }
        [Fact]
        public void ExecuteCommands_NoObstacles_MMMMMMMMMM_Returns_0_0_N()
        {
            // Arrange
            var grid = new Grid(10, 10); // 10x10 grid, no obstacles
            var rover = new MarsRover(grid);

            // Act
            var result = rover.ExecuteCommands("MMMMMMMMMM");

            // Assert
            Assert.Equal("0:0:N", result);
        }
        [Fact]
        public void ExecuteCommands_ObstacleAt_0_3_MMMM_Returns_O_0_2_N()
        {
            // Arrange
            var grid = new Grid(10, 10, obstacles: new[] { (0, 3) }); // 10x10 grid, obstacle at (0,3)
            var rover = new MarsRover(grid);

            // Act
            var result = rover.ExecuteCommands("MMMM");

            // Assert
            Assert.Equal("O:0:2:N", result);
        }
        [Fact]
        public void ExecuteCommands_NoObstacles_LandR_ChangesDirectionCorrectly()
        {
            var grid = new Grid(10, 10);
            var rover = new MarsRover(grid);

            Assert.Equal("0:0:W", rover.ExecuteCommands("L"));
            Assert.Equal("0:0:N", rover.ExecuteCommands("R"));
        }

        [Fact]
        public void ExecuteCommands_NoObstacles_WrapsAroundWestAndSouth()
        {
            var grid = new Grid(10, 10);
            var rover = new MarsRover(grid);

            // Nach links drehen (W), dann 1 Schritt (Wrap von 0 nach 9)
            Assert.Equal("9:0:W", rover.ExecuteCommands("LM"));
            // Nach links drehen (S), dann 1 Schritt (Wrap von 0 nach 9)
            Assert.Equal("0:9:S", rover.ExecuteCommands("LLM"));
        }

        [Fact]
        public void ExecuteCommands_ObstacleAt_0_3_And_0_2_MMM_Returns_O_0_1_N()
        {
            var grid = new Grid(10, 10, obstacles: new[] { (0, 2), (0, 3) });
            var rover = new MarsRover(grid);

            var result = rover.ExecuteCommands("MMM");
            Assert.Equal("O:0:1:N", result);
        }

        [Fact]
        public void ExecuteCommands_ObstacleAt_0_2_MMMRMM_Returns_O_0_1_N()
        {
            var grid = new Grid(10, 10, obstacles: new[] { (0, 2) });
            var rover = new MarsRover(grid);

            // Nach Hindernis ignoriert der Rover weitere Befehle
            var result = rover.ExecuteCommands("MMMRMM");
            Assert.Equal("O:0:1:N", result);
        }
    }
}
