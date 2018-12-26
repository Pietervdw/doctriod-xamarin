using CoreGraphics;
using Doctriod.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(EntryBorderEffect), "EntryBorderEffect")]
namespace Doctriod.iOS.Effects
{
    public class EntryBorderEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            UITextField textField = (UITextField)Control;

            textField.BorderStyle = UITextBorderStyle.RoundedRect;
            textField.BackgroundColor = UIColor.White;
            textField.Layer.BorderColor = Color.FromHex("#D5D5D5").ToCGColor();
            textField.Font = UIFont.FromName("GothamRounded-Book", 20);
            textField.TextColor = UIColor.FromRGB(149, 152, 154);
            textField.TextAlignment = UITextAlignment.Left;
            
        }

        protected override void OnDetached() { }
    }
}