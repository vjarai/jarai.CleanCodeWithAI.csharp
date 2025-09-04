namespace Charger.Original;

public class IPhone
{
    public void Aufladen(LightningLadegerät lightningLadegerät)
    {
        var strom = lightningLadegerät.LiefereStromViaLightning();

        Console.WriteLine($"Apple Phone wird mit {strom} mA aufgeladen.");
    }
}