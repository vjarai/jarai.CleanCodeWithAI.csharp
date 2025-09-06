using System;
using System.Collections.Generic;

namespace Datenbank
{
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
