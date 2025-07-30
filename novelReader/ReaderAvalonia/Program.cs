using Avalonia;
using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using ReaderAvalonia;

class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

        App.Configuration = config;

        BuildAvaloniaApp()
        .SetupWithClassicDesktopLifetime(args);
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<ReaderAvalonia.App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
}
