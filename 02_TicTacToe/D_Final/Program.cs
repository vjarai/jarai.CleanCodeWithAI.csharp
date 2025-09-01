using Jarai.CleanCodeWithAI.TicTacToe.Refactored.Logic;
using Jarai.CleanCodeWithAI.TicTacToe.Refactored.UserInterface;

namespace Jarai.CleanCodeWithAI.TicTacToe.Refactored
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var game = new TicTacToeGame(new ConsoleUserInterface());
            game.Play();
        }
    }
}