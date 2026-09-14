using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia_Lite.Models;

namespace Avalonia_Lite.ViewModels
{
    public partial class AddViewModel : ViewModelBase
    {
        public User User { get; set; }
        public bool IsEdit { get; }

        public AddViewModel(User? user = null)
        {
            IsEdit = user != null;
            User = user ?? new User();
        }

        public void Save()
        {
            // Новую запись добавляем в контекст; изменения существующей 
            // EF Core отслеживает сам, достаточно SaveChanges() 
            if (!IsEdit)
                DbConection.Test320Context.Users.Add(User);
            DbConection.Test320Context.SaveChanges();
        }
    }
}
