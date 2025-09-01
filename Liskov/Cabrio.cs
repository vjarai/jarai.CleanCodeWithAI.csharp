namespace Liskov;

public class Cabrio : Car
{
    private bool _roofIsOpen;

    public Cabrio(string make, string model, Engine engine)
        : base(make, model, engine)
    {
        _roofIsOpen = false;
    }

    public void OpenRoof()
    {
        _roofIsOpen = true;
        Console.WriteLine("Roof opened.");
    }

    public void CloseRoof()
    {
        _roofIsOpen = false;
        Console.WriteLine("Roof closed.");
    }

    public override void Drive(int distance)
    {
        OpenRoof();
        base.Drive(distance);
        CloseRoof();
    }
}