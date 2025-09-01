using Jarai.CleanCodeWithAI.TicTacToe.Final.Logic;
using Jarai.CleanCodeWithAI.TicTacToe.Final.UserInterface;

namespace Jarai.CleanCodeWithAI.TicTacToe.Final
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