using System;
using Jarai.CleanCodeWithAI.TicTacToe.Final.Logic;
using Xunit;

namespace Jarai.CleanCodeWithAI.TicTacToe.Refactored.Tests
{
    public class TicTacToeBoardTests
    {
        [Fact]
        public void GivenMoveToField0_WhenSetField_ThenThrowsException()
        {
            // Arrange
            var board = new TicTacToeBoard();

            // Act & Assert
            Assert.Throws<Exception>(() => board.SetField(0, Player.X));
        }

        [Fact]
        public void GivenMoveToField10_WhenSetField_ThenThrowsException()
        {
            // Arrange
            var board = new TicTacToeBoard();

            // Act & Assert
            Assert.Throws<Exception>(() => board.SetField(0, Player.X));
        }

        [Fact]
        public void GivenNonEmptyField_WhenSetField_ThenThrowsException()
        {
            // Arrange
            var board = new TicTacToeBoard();

            // Act
            board.SetField(1, Player.X);

            // Assert
            Assert.Throws<Exception>(() => board.SetField(1, Player.O));
        }
    }
}