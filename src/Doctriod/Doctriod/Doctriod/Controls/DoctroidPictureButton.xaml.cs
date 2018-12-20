using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Doctriod.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DoctroidPictureButton : ContentView
    {
        public DoctroidPictureButton()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            propertyName: "Text",
            returnType: typeof(string),
            declaringType: typeof(DoctroidPictureButton),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: TextPropertyChanged);

        public string Text
        {
            get { return base.GetValue(TextProperty).ToString(); }
            set { base.SetValue(TextProperty, value); }
        }

        private static void TextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (DoctroidPictureButton)bindable;
            control.ButtonLabel.Text = newValue.ToString();
        }

        public static readonly BindableProperty IconProperty = BindableProperty.Create(
            propertyName: "Icon",
            returnType: typeof(string),
            declaringType: typeof(DoctroidPictureButton),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: IconPropertyChanged);

        public string Icon
        {
            get { return base.GetValue(IconProperty).ToString(); }
            set { base.SetValue(IconProperty, value); }
        }

        private static void IconPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (DoctroidPictureButton)bindable;
            control.ButtonImage.Source = newValue.ToString();

        }
    }
}