using System.Linq;
using Xunit;

namespace Jarai.CleanCodeWithAI.TicTacToe.Exercise.Tests
{
    public class TicTacToeGameTests
    {
        [Fact()]
        public void GivenPlayerX_WhenPlaysWinningMoves_ThenXIsWinner()
        {
            // Arrange
            var userInterface = new FakeUserInterface
            {
                ReadLineBuffer = new[] { "1", "4", "2", "5", "3" }
            };

            var game = new TicTacToeGame(userInterface);

            // Act
            game.Play();

            // Assert
            Assert.Equal("The winner is X!", userInterface.WriteLineBuffer.Last());
        }

        [Fact()]
        public void GivenOccupiedBox_WhenPlayerMoves_ThenErrorBoxNotVacant()
        {
            // Arrange
            var userInterface = new FakeUserInterface
            {
                ReadLineBuffer = new[] { "1", "1", "4", "2", "5", "3" }
            };

            var game = new TicTacToeGame(userInterface);

            // Act
            game.Play();

            // Assert
            Assert.Contains("Error: box not vacant!", userInterface.WriteLineBuffer);
        }

        [Fact()]
        public void GivenOutOfRangeMove_WhenPlayerMoves_ThenErrorWrongSelection()
        {
            // Arrange
            var userInterface = new FakeUserInterface
            {
                ReadLineBuffer = new[] {"99", "1", "1", "4", "2", "5", "3" }
            };

            var game = new TicTacToeGame(userInterface);

            // Act
            game.Play();

            // Assert
            Assert.Contains("Wrong selection entered!", userInterface.WriteLineBuffer);
        }

        [Fact()]
        public void GivenPlayerY_WhenPlaysWinningMoves_ThenYIsWinner()
        {
            // Arrange
            var userInterface = new FakeUserInterface
            {
                ReadLineBuffer = new[] { "1", "4", "2", "5", "9", "6" }
            };

            var game = new TicTacToeGame(userInterface);

            // Act
            game.Play();

            // Assert
            Assert.Equal("The winner is Y!", userInterface.WriteLineBuffer.Last());
        }


        [Fact()]
        public void GivenFullBoardWithoutWinner_WhenGameEnds_ThenNoOneWon()
        {
            // Arrange
            var userInterface = new FakeUserInterface
            {
                ReadLineBuffer = new[] { "1", "4", "2", "5", "6", "3", "9", "8", "7", "-1" }
            };

            var game = new TicTacToeGame(userInterface);

            // Act
            game.Play();

            // Assert
            Assert.Contains("No one won.", userInterface.WriteLineBuffer);
        }

    }
}