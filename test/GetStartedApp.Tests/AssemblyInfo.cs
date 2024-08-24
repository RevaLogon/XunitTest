using Avalonia;
using Avalonia.Headless;
using Xunit;

// This attribute makes sure the Avalonia headless environment is set up for all tests
[assembly: AvaloniaTestApplication(typeof(GetStartedApp.Tests.TestAppBuilder))]
