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
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            SetGradientBackground();
        }

        private void SetGradientBackground()
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
}