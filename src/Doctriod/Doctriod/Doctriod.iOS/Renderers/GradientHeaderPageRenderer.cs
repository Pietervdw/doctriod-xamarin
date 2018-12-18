using CoreAnimation;
using CoreGraphics;
using Doctriod.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ContentPage), typeof(GradientHeaderPageRenderer))]
namespace Doctriod.iOS.Renderers
{
    public class GradientHeaderPageRenderer : PageRenderer
    {
        //UILabel _titleLabel;

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            SetGradientBackground();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SetTitle();
        }

        private void SetGradientBackground()
        {
            if (NavigationController != null)
            {
                Color startColor = Color.FromHex("#19769f");
                Color endColor = Color.FromHex("#35d8a6");

                var gradientLayer = new CAGradientLayer();
                gradientLayer.Bounds = NavigationController.NavigationBar.Bounds;
                gradientLayer.Colors = new CGColor[] { startColor.ToCGColor(), endColor.ToCGColor() };
                gradientLayer.StartPoint = new CGPoint(0.0, 0.5);
                gradientLayer.EndPoint = new CGPoint(1.0, 0.5);

                UIGraphics.BeginImageContext(gradientLayer.Bounds.Size);
                gradientLayer.RenderInContext(UIGraphics.GetCurrentContext());
                UIImage image = UIGraphics.GetImageFromCurrentImageContext();
                UIGraphics.EndImageContext();

                NavigationController.NavigationBar.SetBackgroundImage(image, UIBarMetrics.Default);
            }
        }

        private void SetTitle()
        {
            var att = new UITextAttributes();
            UIFont customFont = UIFont.FromName("GothamRounded-Bold", 20);
            att.Font = customFont;
            att.TextColor = UIColor.White;
            UINavigationBar.Appearance.SetTitleTextAttributes(att);
        }
    }
}