using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Datenbank
{
    /// <summary>
    /// Represents a customer in the Shopping database.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the unique identifier for the customer.
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Gets or sets the email address of the customer.
        /// </summary>
        public string Email { get; set; } = string.Empty;
    }

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

    /// <summary>
    /// Main program class for listing all customers from the Shopping database.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Application entry point. Lists all customers on the console.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            using (var context = new ShoppingContext())
            {
                foreach (var customer in context.Customers)
                {
                    Console.WriteLine($"Name: {customer.Name}, Email: {customer.Email}");
                }
            }
        }
    }
}
