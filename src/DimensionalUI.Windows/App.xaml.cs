using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DimensionalUI.App.Views;

namespace DimensionalUI.Windows;

public sealed partial class App : Application
{
    public App()
    {
        this.InitializeComponent();
    }

    protected override void OnLaunched(Windows.ApplicationModel.Activation.LaunchActivatedEventArgs args)
    {
        var rootFrame = Window.Current.Content as Frame;
        if (rootFrame == null)
        {
            rootFrame = new Frame();
            Window.Current.Content = rootFrame;
        }

        if (rootFrame.Content == null)
        {
            rootFrame.Navigate(typeof(DimensionalShellPage));
        }

        Window.Current.Activate();
    }
}
