using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
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
    }
    }
}