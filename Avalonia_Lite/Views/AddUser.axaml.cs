using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia_Lite.Models;
using Avalonia_Lite.ViewModels;

namespace Avalonia_Lite.Views
{
    public partial class AddUser : Window
    {
        public AddUser(User? user = null)
        {
            InitializeComponent();
            DataContext = new AddViewModel(user);
        }

        private void btnAdd_Click(object? sender, RoutedEventArgs e)
        {
            if (DataContext is AddViewModel viewModel)
            {
                viewModel.Save();
                this.Close();
            }
        }
    }
}