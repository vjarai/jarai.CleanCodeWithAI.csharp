using System.Linq;
using Jarai.CleanCodeWithAI.TicTacToe.Refactored.Logic;
using Xunit;

namespace Jarai.CleanCodeWithAI.TicTacToe.Refactored.Tests
{
    public class TicTacToeGameTests
    {
        [Fact()]
        public void GivenPlayerX_WhenPlaysWinningMoves_ThenXIsWinner()
        {
            // Arrange
            var userInterface = new FakeUserInterface
            {
                ReadLineBuffer = new[] {0, 1, 4, 2, 5, 3 }
            };

            var game = new TicTacToeGame(userInterface);

            // Act
            game.Play();

            // Assert
            Assert.Equal("The winner is X!", userInterface.WriteLineBuffer.Last());
        }

        [Fact()]
        public void GivenPlayerO_WhenPlaysWinningMoves_ThenOIsWinner()
        {
            // Arrange
            var userInterface = new FakeUserInterface
            {
                ReadLineBuffer = new[] { 1, 4, 2, 5, 9, 6 }
            };

            var game = new TicTacToeGame(userInterface);

            // Act
            game.Play();

            // Assert
            Assert.Equal("The winner is O!", userInterface.WriteLineBuffer.Last());
        }

        [Fact()]
        public void GivenFullBoardWithoutWinner_WhenGameEnds_ThenNoOneWon()
        {
            // Arrange
            var userInterface = new FakeUserInterface
            {
                ReadLineBuffer = new[] { 1, 4, 2, 5, 6, 3, 9, 8, 7, -1 }
            };

            var game = new TicTacToeGame(userInterface);

            // Act
            game.Play();

            // Assert
            Assert.Contains("No one won.", userInterface.WriteLineBuffer);
        }
    }
}