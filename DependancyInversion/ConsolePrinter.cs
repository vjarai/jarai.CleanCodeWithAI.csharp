using System;

namespace DependancyInversion
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine(document);
        }
    }
}