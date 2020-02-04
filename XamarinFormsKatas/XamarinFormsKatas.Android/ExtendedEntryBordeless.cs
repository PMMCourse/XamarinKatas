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

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryBordeless))]
namespace XamarinFormsKatas.Droid
{
    public class ExtendedEntryBordeless : EntryRenderer
    {
        public ExtendedEntryBordeless(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            var elemento = new GradientDrawable();
            elemento.SetShape(ShapeType.Rectangle);
            elemento.SetStroke(0, Android.Graphics.Color.Transparent);
            Control.SetBackground(elemento);
            //SE ELIMINA EL BORDE PERO TIENE QUE CLICKAR PORQUE SINO NO SE VE EL ENTRY AL
            // NO TENER BORDE
        }
    }
}