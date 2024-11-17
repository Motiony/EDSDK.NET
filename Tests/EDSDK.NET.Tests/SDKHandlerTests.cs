namespace EDSDK.NET.Tests;

public class SDKHandlerTests
{
    [Fact]
    public void GetCameraList_ListShouldNotBeNull()
    {
        var sdkHandler = new SDKHandler();
        var version = sdkHandler.GetCameraList();

        Assert.NotNull(version);
    }
}