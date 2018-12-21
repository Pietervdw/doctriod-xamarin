using CoreAnimation;
using CoreGraphics;
using Doctriod.iOS.Renderers;
using Doctriod.NavPage;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(GradientContentPage), typeof(GradientContentPageRenderer))]
namespace Doctriod.iOS.Renderers
{
    public class GradientContentPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null) // perform initial setup
            {
                var page = e.NewElement as GradientContentPage;
                var gradientLayer = new CAGradientLayer();
                gradientLayer.Frame = View.Bounds;
                gradientLayer.Colors = new CGColor[] { page.StartColor.ToCGColor(), page.EndColor.ToCGColor() };
                View.Layer.InsertSublayer(gradientLayer, 0);
            }
        }
    }
}