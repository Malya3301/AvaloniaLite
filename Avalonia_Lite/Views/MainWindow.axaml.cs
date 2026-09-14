using Avalonia.Controls;

namespace Avalonia_Lite.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainControl.Content = new LoginPage();
    }
}