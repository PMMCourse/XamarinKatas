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
using XamarinFormsKatas.Katas_UI.Kata_q.Controls;
[assembly:ExportRenderer(typeof(Xamarin.Forms.Platform.Android.EntryRenderer),typeof(entryBorderRenderer))]
namespace XamarinFormsKatas.Droid
{
    public class entryBorderRenderer: EntryRenderer
    {
        public entryBorderRenderer(Context contexto) : base(contexto)
        {
            
        }
        protected override void CambioElemento(ElementChangedEventArgs<Entry> e)
        {
            var element = new GradientDrawable();
            element.SetShape(ShapeType.Rectangle);
            element.SetStroke(0, Android.Graphics.Color.Transparent);
            Control.setBackgroung(element);
        }
    }
}