namespace Jarai.CleanCodeWithAI.TicTacToe.Testable
{
    public interface IUserInterface
    {
        void WriteLine(string format, params object[] args);
        void WriteLine();
        void Clear();
        void ReadKey();
        void Write(string text);
        string ReadLine();
    }
}