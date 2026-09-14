using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace Avalonia_Lite.Views
{
    public partial class ConfirmDialog : Window
    {
        public ConfirmDialog(string text)
        {
            InitializeComponent();
            QuestionText.Text = text;
        }

        private void btnYes_Click(object? sender, RoutedEventArgs e) => Close(true);
        private void btnNo_Click(object? sender, RoutedEventArgs e) => Close(false);
    }
}