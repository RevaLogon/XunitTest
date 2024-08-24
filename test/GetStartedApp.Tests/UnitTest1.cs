using Avalonia.Controls;
using Avalonia.Headless;
using GetStartedApp.ViewModels;
using GetStartedApp;
using Xunit;

namespace GetStartedApp.Tests
{
    public class MainWindowViewModelTests
    {
        [Fact]
        public void Should_Perform_Addition()
        {
            // Create and set up the MainWindow
            var viewModel = new MainWindowViewModel();
            var mainWindow = new MainWindow { DataContext = viewModel };

            // Set input values
            viewModel.FirstNumber = "5";
            viewModel.SecondNumber = "3";

            // Execute the Add command
            viewModel.AddCommand.Execute(null);

            // Assert the result
            var resultTextBlock = FindControl<TextBlock>(mainWindow, "ResultTextBlock");
            Assert.NotNull(resultTextBlock);
            Assert.Equal("8", resultTextBlock.Text); 
        }

        private static T? FindControl<T>(Control parent, string name) where T : Control
        {
            return parent.FindControl<T>(name);
        }
    }
}
