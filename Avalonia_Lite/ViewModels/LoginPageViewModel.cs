using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia_Lite.Models;
using Avalonia_Lite.Views;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_Lite.ViewModels
{
    public partial class LoginPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<User> _users = new();

        [ObservableProperty]
        private User? _selectedUser;

        public LoginPageViewModel()
        {
            Refresh();
        }

        public void Refresh()
        {
            Users = new ObservableCollection<User>(DbConection.Test320Context.Users.ToList());
        }

        
    }
}
