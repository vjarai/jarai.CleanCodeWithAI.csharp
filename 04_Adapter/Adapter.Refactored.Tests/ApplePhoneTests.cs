using Adapter.Refactored;
using Moq;
using Xunit;

public class ApplePhoneTests
{
    [Fact]
    public void Aufladen_WithUsbToLightningAdapter_CallsLiefereStromViaUsb()
    {
        // Arrange
        var usbLadeger�tMock = new Mock<UsbLadeger�t>();
        usbLadeger�tMock.Setup(x => x.LiefereStromViaUsb()).Returns(500);

        var adapter = new UsbToLightningAdapter(usbLadeger�tMock.Object);
        var applePhone = new ApplePhone();

        // Act
        applePhone.Aufladen(adapter);

        // Assert
        usbLadeger�tMock.Verify(x => x.LiefereStromViaUsb(), Times.Once);
    }
}