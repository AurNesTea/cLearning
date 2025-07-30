using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.Configuration;
using ReaderAvalonia;
using ReaderAvalonia.Views;

namespace ReaderAvalonia;
public partial class App : Application
{
    public static IConfiguration? Configuration { get; set; }

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow { Content = new MainView() };
        }

        base.OnFrameworkInitializationCompleted();
    }
}

