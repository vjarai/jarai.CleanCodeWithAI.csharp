using Jarai.CleanCodeWithAI.TicTacToe.Refactored.Logic;

namespace Jarai.CleanCodeWithAI.TicTacToe.Refactored.UserInterface
{
    public interface IUserInterface
    {
        int GetMove(Player player);
        void ShowBoard(TicTacToeBoard board);
        void ShowMessage(string message);
    }
}