using Jarai.CleanCodeWithAI.TicTacToe.Final.Logic;

namespace Jarai.CleanCodeWithAI.TicTacToe.Final.UserInterface
{
    public interface IUserInterface
    {
        int GetMove(Player player);
        void ShowBoard(TicTacToeBoard board);
        void ShowMessage(string message);
    }
}