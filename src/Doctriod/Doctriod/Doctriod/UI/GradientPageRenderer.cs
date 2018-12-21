using Xamarin.Forms;

namespace Doctriod.NavPage
{
    //https://forums.xamarin.com/discussion/22440/gradient-as-background-color
    //https://stackoverflow.com/questions/28848545/add-gradient-background-to-layouts-in-xamarin-forms-visual-studio
    //https://github.com/tbaggett/xfgloss
    public class GradientContentPage : ContentPage
    {
        public GradientContentPage()
        {
            StartColor = Color.FromHex("#19769f");
            EndColor = Color.FromHex("#35d8a6"); 
        }
        public Xamarin.Forms.Color StartColor { get; set; }
        public Xamarin.Forms.Color EndColor { get; set; }
    }
}