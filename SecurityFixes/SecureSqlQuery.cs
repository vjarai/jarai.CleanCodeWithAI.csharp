using Microsoft.Data.SqlClient;

namespace SecurityFixes;

internal class SecureSqlQuery
{
    public static void Execute()
    {
        Console.WriteLine("Enter username:");
        var username = Console.ReadLine()!;

        Console.WriteLine("Enter password:");
        var password = Console.ReadLine()!;

        var connectionString = "Server=.;Database=TestDB;Trusted_Connection=True;";

        // Safe version: input is bound to parameters (@username, @password), so the database treats them as data, not executable code.
        var query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";

        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();

            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
                Console.WriteLine("Login successful!");
            else
                Console.WriteLine("Login failed.");
        }
    }
}