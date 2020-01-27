using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsKatas.Droid;
using XamarinFormsKatas.Katas_UI.Kata_j.Controls;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace XamarinFormsKatas.Droid
{
    public class ExtendedEntryRenderer: EntryRenderer
    {
        public ExtendedEntryRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e) {
            base.OnElementChanged(e);
            //Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            var elemento = new GradientDrawable();
            elemento.SetShape(ShapeType.Rectangle);
            elemento.SetStroke(2, Android.Graphics.Color.Black);
            Control.SetBackground(elemento);
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == "BorderColor")
            {
                var entry = (Xamarin.Forms.Entry)sender;
                var elemento = new GradientDrawable();
                elemento.SetShape(ShapeType.Rectangle);
                elemento.SetStroke(2, Android.Graphics.Color.Red);
                Control.SetBackground(elemento);
            }
        }
    }
}