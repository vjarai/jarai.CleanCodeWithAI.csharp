namespace Adapter.Refactored;

public class UsbToLightningAdapter : LightningLadegerät
{
    private readonly UsbLadegerät _usbLadegerät;

    public UsbToLightningAdapter(UsbLadegerät usbLadegerät)
    {
        _usbLadegerät = usbLadegerät;
    }


    public override int LiefereStromViaLightning()
    {
        var strom = _usbLadegerät.LiefereStromViaUsb();


        return strom;
    }
}