using System;
using Doctriod.NavPage;
using Xamarin.Forms;

namespace Doctriod.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            CustomNavigationPage.SetGradientColors(this, new Tuple<Color, Color>(Color.FromHex("#19769f"), Color.FromHex("#35d8a6")));
            CustomNavigationPage.SetGradientDirection(this, CustomNavigationPage.GradientDirection.LeftToRight);
        }
    }
}
