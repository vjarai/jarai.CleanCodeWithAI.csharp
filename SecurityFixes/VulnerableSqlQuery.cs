using Microsoft.Data.SqlClient;

namespace SecurityFixes;

internal class VulnerableSqlQuery
{
    public static void Execute()
    {
        Console.WriteLine("Enter username:");
        var username = Console.ReadLine()!;

        Console.WriteLine("Enter password:");
        var password = Console.ReadLine()!;

        // ❌ Vulnerable code: concatenates user input directly into SQL
        // If an attacker enters:
        // Username: alice' OR '1'='1
        // Password: anything
        // The query becomes:
        // SELECT * FROM Users WHERE Username = 'alice' OR '1'='1' AND Password = 'anything'

        var connectionString = "Server=.;Database=TestDB;Trusted_Connection=True;";
        var query = "SELECT * FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "'";

        using (var conn = new SqlConnection(connectionString))
        {
            var cmd = new SqlCommand(query, conn);
            conn.Open();
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
                Console.WriteLine("Login successful!");
            else
                Console.WriteLine("Login failed.");
        }
    }
}