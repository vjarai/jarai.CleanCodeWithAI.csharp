namespace Charger.Original;

public class UsbLadegerät
{
    public int LiefereStromViaUsb()
    {
        var strom = 500;

        Console.WriteLine($"USB Ladegerät liefert {strom} mA Strom.");

        return strom;
    }
}