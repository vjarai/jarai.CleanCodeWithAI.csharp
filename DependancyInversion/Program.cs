using System.Reflection;
using InterfaceSegragation;

namespace DependancyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var printer = new SimplePrinter();
            var docManager = new DocumentManager(printer);
            
            docManager.PrintDocument("Hello, Dependency Inversion Principle!");

        }
    }
}
