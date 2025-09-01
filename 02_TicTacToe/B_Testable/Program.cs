namespace Jarai.CleanCodeWithAI.TicTacToe.Testable
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var game = new TicTacToeGame(new UserInterface());
            game.Play();
        }
    }
}