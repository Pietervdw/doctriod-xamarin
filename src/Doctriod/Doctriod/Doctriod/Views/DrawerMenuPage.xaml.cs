using Xamarin.Forms;

namespace Doctriod.Views
{
    public partial class DrawerMenuPage : MasterDetailPage
    {
        public DrawerMenuPage()
        {
            InitializeComponent();
      
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //EntrySize.Text = $"{ImageAvatar.Width.ToString()},{ImageAvatar.Height.ToString()} ";
        }
    }
}