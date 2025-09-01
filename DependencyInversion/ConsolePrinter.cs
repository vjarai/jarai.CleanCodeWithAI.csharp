using System;

namespace DependencyInversion
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine(document);
        }
    }
}