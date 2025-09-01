namespace DependencyInversion;

public class DocumentManager
{
    private readonly IPrinter _printer;

    public DocumentManager(IPrinter printer)
    {
        _printer = printer;
    }

    public void PrintDocument(string content)
    {
        _printer.Print(content);
    }
}