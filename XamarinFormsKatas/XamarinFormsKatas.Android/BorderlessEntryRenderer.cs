using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsKatas.Droid;
using XamarinFormsKatas.Katas_UI.Kata_q;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]

namespace XamarinFormsKatas.Droid
{
    [Obsolete]
    public class BorderlessEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;
            }
        }
    }
}