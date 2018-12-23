using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Doctriod.Models;

namespace Doctriod.ViewModels
{
    public class DrawerMenuPageViewModel : BindableBase
    {
        private ObservableCollection<MenuItem> _menuItems;
        public ObservableCollection<MenuItem> MenuItems
        {
            get => _menuItems;
            set => SetProperty(ref _menuItems, value);
        }

        public DrawerMenuPageViewModel()
        {
            InitMenu();
        }

        private void InitMenu()
        {
            MenuItems = new ObservableCollection<MenuItem>();
            MenuItems.Add(new MenuItem() { Title = "HOME", Page = "Home", IsActive = false, IsFirst = true, MustBeLoggedIn = false });
            MenuItems.Add(new MenuItem() { Title = "DOCTORS", Page = "Doctors", IsActive = false, MustBeLoggedIn = false });
            MenuItems.Add(new MenuItem() { Title = "HOSPITALS", Page = "Hospitals", IsActive = true, MustBeLoggedIn = false });
            MenuItems.Add(new MenuItem() { Title = "INSURANCE", Page = "Insurance", IsActive = false, MustBeLoggedIn = false });
            MenuItems.Add(new MenuItem() { Title = "HISTORY", Page = "History", IsActive = false, MustBeLoggedIn = false });
            MenuItems.Add(new MenuItem() { Title = "MEDICINE", Page = "Medicine", IsActive = false, MustBeLoggedIn = false });
            MenuItems.Add(new MenuItem() { Title = "LOG OUT", Page = "LogOut", IsActive = false, MustBeLoggedIn = false });
        }
    }
}
