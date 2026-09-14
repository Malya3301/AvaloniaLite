using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia_Lite.Models;
using Avalonia_Lite.ViewModels;

namespace Avalonia_Lite.Views
{
    public partial class LoginPage : UserControl
    {
        private LoginPageViewModel viewModel { get; set; }

        public LoginPage()
        {
            InitializeComponent();
            viewModel = new LoginPageViewModel();
            DataContext = viewModel;
        }

        private async void btnTest_Click(object? sender, RoutedEventArgs e)
        {
            var window = new AddUser();

            if (TopLevel.GetTopLevel(this) is Window owner) { await window.ShowDialog(owner); }   // ждём закрытия окна 
            else
            {
                window.Show();
            }

            viewModel.Refresh();
        }

        private async void MainDataGridUsers_DoubleTapped(object? sender, TappedEventArgs e)
        {
            if (viewModel.SelectedUser is not User selected) return;

            var window = new AddUser(selected);   // режим редактирования 
            if (TopLevel.GetTopLevel(this) is Window owner)
                await window.ShowDialog(owner);

            viewModel.Refresh();
        }
    }
}