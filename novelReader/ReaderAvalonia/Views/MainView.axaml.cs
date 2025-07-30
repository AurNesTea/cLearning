using Avalonia.Controls;
using Avalonia.Interactivity;
using System.IO;

namespace ReaderAvalonia.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        OpenFileButton.Click += OpenFileButton_Click;
    }

    private async void OpenFileButton_Click(object? sender, RoutedEventArgs e)
    {
        var dialog = new OpenFileDialog
        {
            Title = "選擇檔案",
            AllowMultiple = false,
        };

        var result = await dialog.ShowAsync((Window)this.VisualRoot);

        if (result != null && result.Length > 0)
        {
            string filePath = result[0];
            string content = await File.ReadAllTextAsync(filePath);
            ContentBox.Text = content;
        }
    }
}
