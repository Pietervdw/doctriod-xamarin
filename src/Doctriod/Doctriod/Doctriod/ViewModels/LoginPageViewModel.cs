using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace Doctriod.ViewModels
{
    public class LoginPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        async void ExecuteNavigateCommand()
        {
            Settings.ActiveMenu = "HomeTabbed";
            await _navigationService.NavigateAsync($"/Index/Navigation/HomeTabbed");
        }
        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
