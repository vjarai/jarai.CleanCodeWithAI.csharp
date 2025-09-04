namespace Adapter.Refactored;

public class UsbLadegerät
{
    public virtual int LiefereStromViaUsb()
    {
        var strom = 500;

        Console.WriteLine($"USB Ladegerät liefert {strom} mA Strom.");

        return strom;
    }
}