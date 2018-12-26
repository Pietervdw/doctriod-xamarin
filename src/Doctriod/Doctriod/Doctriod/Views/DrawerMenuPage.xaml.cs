using Xamarin.Forms;

namespace Doctriod.Views
{
    public partial class DrawerMenuPage : MasterDetailPage
    {
        public DrawerMenuPage()
        {
            InitializeComponent();
            MenuItemsListView.ItemTapped += MenuItemsListView_ItemTapped;
        }

        private void MenuItemsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
    }
}