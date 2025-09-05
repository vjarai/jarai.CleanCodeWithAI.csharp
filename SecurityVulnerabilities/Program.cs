using SecurityFixes;


// https://docs.github.com/en/copilot/tutorials/copilot-chat-cookbook/analyze-security/find-vulnerabilities


internal class Program
{
    private static void Main()
    {
        VulnerableSqlQuery.Execute();
        SecureSqlQuery.Execute();
    }
}