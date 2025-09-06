using Microsoft.EntityFrameworkCore;

namespace Datenbank;

/// <summary>
/// Entity Framework database context for the Shopping database.
/// </summary>
public class ShoppingContext : DbContext
{
    /// <summary>
    /// Gets or sets the Customers table.
    /// </summary>
    public DbSet<Customer> Customers { get; set; }

    /// <summary>
    /// Configures the database connection for the context.
    /// </summary>
    /// <param name="optionsBuilder">The options builder to configure.</param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Shopping;Trusted_Connection=True;");
    }
}