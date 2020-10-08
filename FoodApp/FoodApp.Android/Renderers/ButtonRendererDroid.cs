
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using FoodApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Button),typeof(ButtonRendererDroid))]
namespace FoodApp.Droid.Renderers
{
    public class ButtonRendererDroid : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            Control.SetAllCaps(false);
        }
        public ButtonRendererDroid(Context context) : base(context)
        {
        }
    }
}