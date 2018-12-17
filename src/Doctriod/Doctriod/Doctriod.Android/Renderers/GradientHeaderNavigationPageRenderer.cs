using System;
using System.ComponentModel;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Doctriod.Droid.Renderers;
using Doctriod.NavPage;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;
using Color = Xamarin.Forms.Color;

[assembly: ExportRenderer(typeof(GradientHeaderNavigationPage), typeof(GradientHeaderNavigationPageRenderer))]
namespace Doctriod.Droid.Renderers
{
    public class GradientHeaderNavigationPageRenderer : NavigationPageRenderer
    {
        Android.Support.V7.Widget.Toolbar _toolbar;
        Android.Widget.FrameLayout _parentLayout;
        LinearLayout _titleViewLayout;
        AppCompatTextView _titleTextView;
        AppCompatTextView _subTitleTextView;
        Drawable _originalDrawable;
        Typeface _originalFont;
        Drawable _originalToolbarBackground;
        Drawable _originalWindowContent;

        public GradientHeaderNavigationPageRenderer(Context context) : base(context)
        {

        }

   
        public override void OnViewAdded(Android.Views.View child)
        {
            base.OnViewAdded(child);
            if (child.GetType() == typeof(Android.Support.V7.Widget.Toolbar))
            {
                var lastPage = Element?.Navigation?.NavigationStack?.Last();

                _toolbar = (Android.Support.V7.Widget.Toolbar)child;
                _originalToolbarBackground = _toolbar.Background;

                var originalContent = (Context as Activity)?.Window?.DecorView?.FindViewById<FrameLayout>(Window.IdAndroidContent);
                if (originalContent != null)
                {
                    _originalWindowContent = originalContent.Foreground;
                }

                _parentLayout = new Android.Widget.FrameLayout(_toolbar.Context)
                {
                    LayoutParameters = new Android.Widget.FrameLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent)
                };

                //Create custom title view layout
                _titleViewLayout = new Android.Widget.LinearLayout(_parentLayout.Context)
                {
                    Orientation = Android.Widget.Orientation.Vertical,
                    LayoutParameters = new Android.Widget.FrameLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent)
                };

                //Create custom title text view
                _titleTextView = new AppCompatTextView(_parentLayout.Context)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent)
                };

                //Create custom subtitle text view
                _subTitleTextView = new AppCompatTextView(_parentLayout.Context)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent)
                };

                //Add title/subtitle to title view layout
                _titleViewLayout.AddView(_titleTextView);
                _titleViewLayout.AddView(_subTitleTextView);

                //Add title view layout to main layout
                _parentLayout.AddView(_titleViewLayout);

                //Add main layout to toolbar
                _toolbar.AddView(_parentLayout);

                _toolbar.ChildViewAdded += OnToolbarChildViewAdded;

                SetGradientBackground(_toolbar);
            }
        }

 

        private void OnToolbarChildViewAdded(object sender, ChildViewAddedEventArgs e)
        {
            var view = e.Child.GetType();

            if (e.Child.GetType() == typeof(AppCompatTextView))
            {

                var textView = (AppCompatTextView)e.Child;
                textView.Visibility = ViewStates.Gone;
                _originalDrawable = textView.Background;
                _originalFont = textView.Typeface;

                var lastPage = Element?.Navigation?.NavigationStack?.Last();
                //SetupToolbarCustomization(lastPage);
            }
        }

        private void SetGradientBackground(Android.Support.V7.Widget.Toolbar toolbar)
        {
            Tuple<Color, Color> colors = new Tuple<Color, Color>(Color.FromHex("#19769f"), Color.FromHex("#35d8a6"));
            var direction = GradientDrawable.Orientation.LeftRight;
            GradientDrawable gradient = new GradientDrawable(direction, new int[] { colors.Item1.ToAndroid().ToArgb(), colors.Item2.ToAndroid().ToArgb() });
            gradient.SetCornerRadius(0f);
            toolbar.SetBackground(gradient);
        }

    }
}