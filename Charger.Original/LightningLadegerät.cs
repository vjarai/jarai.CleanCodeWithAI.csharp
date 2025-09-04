namespace Charger.Original;

public class LightningLadegerät
{
    public virtual int LiefereStromViaLightning()
    {
        var strom = 1000;

        Console.WriteLine($"Lightning Ladegerät liefert {strom} mA Strom.");

        return strom;
    }
}