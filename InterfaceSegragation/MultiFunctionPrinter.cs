namespace InterfaceSegragation;

public class MultiFunctionPrinter : IPrinter, IScanner
{
    public void Print(string document)
    {
        Console.WriteLine($"Printing: {document}");
    }

    public void Scan(string document)
    {
        Console.WriteLine($"Scanning: {document}");
    }
}