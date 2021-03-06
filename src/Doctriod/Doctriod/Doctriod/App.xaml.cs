﻿using Doctriod.NavPage;
using Prism;
using Prism.Ioc;
using Doctriod.ViewModels;
using Doctriod.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Doctriod
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            Settings.ActiveMenu = "HomeTabbed";
            await NavigationService.NavigateAsync("/Index/Navigation/HomeTabbed");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<GradientHeaderNavigationPage>("Navigation");
            containerRegistry.RegisterForNavigation<DrawerMenuPage, DrawerMenuPageViewModel>("Index");
            
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>("Home");
            containerRegistry.RegisterForNavigation<HomeTabbedPage, HomeTabbedPageViewModel>("HomeTabbed");
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>("Login");

            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();

            containerRegistry.RegisterForNavigation<MedicinePage, MedicinePageViewModel>("Medicine");
            containerRegistry.RegisterForNavigation<ContactsPage, ContactsPageViewModel>();
            containerRegistry.RegisterForNavigation<SettingsPage, SettingsPageViewModel>();

        }
    }
}
