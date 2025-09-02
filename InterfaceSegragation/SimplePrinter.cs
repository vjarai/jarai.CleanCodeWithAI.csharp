namespace InterfaceSegregation;

public class SimplePrinter : IPrinter
{
    public void Print(string document)
    {
        Console.WriteLine($"Printing: {document}");
    }
}