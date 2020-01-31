using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

namespace XamarinFormsKatas.Droid
{
    public class EntryRenderer:Entry
    {
        public static BindableProperty PropertythicknessBorder = BindableProperty.Create(nameof(thicknessBorder), typeof(int), typeof(EntryRenderer), 0);
        public static BindableProperty PropertyColorBorder = BindableProperty.Create(nameof(ColorBorder), typeof(Color), typeof(EntryRenderer), Color.Transparent);

        public EntryRenderer(Context contexto)
        {
        }

        public Color ColorBorder
        {
            get => (Color)GetValue(PropertyColorBorder);
            set => SetValue(PropertyColorBorder, value);
        }
        public int thicknessBorder
        {
            get => (int)GetValue(PropertythicknessBorder);
            set => SetValue(PropertythicknessBorder,value);
        }
    }
}