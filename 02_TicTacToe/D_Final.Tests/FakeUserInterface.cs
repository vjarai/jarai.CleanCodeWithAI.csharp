using System.Collections.Generic;
using Jarai.CleanCodeWithAI.TicTacToe.Final.Logic;
using Jarai.CleanCodeWithAI.TicTacToe.Final.UserInterface;

namespace Jarai.CleanCodeWithAI.TicTacToe.Final.Tests
{
    public class FakeUserInterface : IUserInterface
    {
        private int _readLineBufferIndex;

        public int[] ReadLineBuffer { get; set; }

        public List<string> WriteLineBuffer { get; } = new List<string>();


        public int GetMove(Player player)
        {
            return ReadLineBuffer[_readLineBufferIndex++];
        }

        public void ShowBoard(TicTacToeBoard board)
        {
        }

        public void ShowMessage(string message)
        {
            WriteLineBuffer.Add(message);
        }
    }
}