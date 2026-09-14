using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia_Lite.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia_Lite.ViewModels
{
    internal partial class LoginPageViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<User> _users = new();

        public LoginPageViewModel()
        {
            Refresh();
        }

        public void Refresh()
        {
            Users = new ObservableCollection<User>(
                DbConection.Test320Context.Users.ToList());
        }
    }
}
