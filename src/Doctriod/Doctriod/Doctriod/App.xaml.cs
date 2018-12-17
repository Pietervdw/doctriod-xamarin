using Doctriod.NavPage;
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

            //MainPage = new CustomNavigationPage(new HomePage());
            await NavigationService.NavigateAsync("Navigation/Home");
            
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<GradientHeaderNavigationPage>("Navigation");
            containerRegistry.RegisterForNavigation<CustomNavigationPage>("Navigation");
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>("Home");
        }
    }
}
