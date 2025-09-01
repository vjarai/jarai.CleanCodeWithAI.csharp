using System.Reflection;

namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var printer = new ConsolePrinter();
            var docManager = new DocumentManager(printer);
            
            docManager.PrintDocument("Hello, Dependency Inversion Principle!");

        }
    }
}
