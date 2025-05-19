using Foundation;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace MauiMVUTest;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
