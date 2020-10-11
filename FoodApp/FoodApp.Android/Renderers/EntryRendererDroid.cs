using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FoodApp.Customs;
using FoodApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(EntryRendererDroid))]
namespace FoodApp.Droid.Renderers
{
    public class EntryRendererDroid : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(30f);
                gradientDrawable.SetColor(Android.Graphics.Color.Rgb(108, 196, 180));
                gradientDrawable.SetSize(570, 49);
                Control.SetBackground(gradientDrawable);

                Control.SetPadding(25, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            }
        }
        public EntryRendererDroid(Context context) : base(context)
        {

        }
    }
}