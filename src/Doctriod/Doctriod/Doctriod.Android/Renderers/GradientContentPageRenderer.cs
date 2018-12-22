using Android.Content;
using Doctriod.Droid.Renderers;
using Doctriod.NavPage;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(GradientContentPage), typeof(GradientContentPageRenderer))]
namespace Doctriod.Droid.Renderers
{
    public class GradientContentPageRenderer : PageRenderer
    {
        public GradientContentPageRenderer(Context context) : base(context) { }

        private Xamarin.Forms.Color StartColor { get; set; }
        private Xamarin.Forms.Color EndColor { get; set; }
        protected override void DispatchDraw(
            global::Android.Graphics.Canvas canvas)
        {
            var gradient = new Android.Graphics.LinearGradient(0, 0, 0, Height,
                this.StartColor.ToAndroid(),
                this.EndColor.ToAndroid(),
                Android.Graphics.Shader.TileMode.Mirror);
            var paint = new Android.Graphics.Paint()
            {
                Dither = true,
            };
            paint.SetShader(gradient);
            canvas.DrawPaint(paint);
            base.DispatchDraw(canvas);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }
            var page = e.NewElement as GradientContentPage;
            this.StartColor = page.StartColor;
            this.EndColor = page.EndColor;
        }
    }
}