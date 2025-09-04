namespace Charger.Original;

internal class Program
{
    private static void Main(string[] args)
    {
        var iphone = new IPhone();

        var lightningLadegerät = new LightningLadegerät();
        iphone.Aufladen(lightningLadegerät);

        var usbLadegerät = new UsbLadegerät();
        // applePhone.Aufladen(usbLadegerät);   // Geht nicht! Was tun?

        Console.Read();
    }
}