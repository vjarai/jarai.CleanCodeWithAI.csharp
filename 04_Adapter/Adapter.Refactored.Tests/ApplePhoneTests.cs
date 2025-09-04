using Adapter.Refactored;
using Moq;
using Xunit;

public class ApplePhoneTests
{
    [Fact]
    public void Aufladen_WithUsbToLightningAdapter_CallsLiefereStromViaUsb()
    {
        // Arrange
        var usbLadegerätMock = new Mock<UsbLadegerät>();
        usbLadegerätMock.Setup(x => x.LiefereStromViaUsb()).Returns(500);

        var adapter = new UsbToLightningAdapter(usbLadegerätMock.Object);
        var applePhone = new ApplePhone();

        // Act
        applePhone.Aufladen(adapter);

        // Assert
        usbLadegerätMock.Verify(x => x.LiefereStromViaUsb(), Times.Once);
    }
}