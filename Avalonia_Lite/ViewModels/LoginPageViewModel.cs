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

        [ObservableProperty]
        private string _searchText = "";

        partial void OnSearchTextChanged(string value) => Refresh();
        public LoginPageViewModel()
        {
            Refresh();
        }

        public void Refresh()
        {
            var query = DbConection.Test320Context.Users.AsQueryable();
            if (!string.IsNullOrWhiteSpace(SearchText))
                query = query.Where(u => u.Name != null && u.Name.Contains(SearchText));
            Users = new ObservableCollection<User>(query.ToList());
        }

        public void DeleteSelected()
        {
            if (SelectedUser == null) return;
            DbConection.Test320Context.Users.Remove(SelectedUser);
            DbConection.Test320Context.SaveChanges();
            Refresh();
        }


    }
}
