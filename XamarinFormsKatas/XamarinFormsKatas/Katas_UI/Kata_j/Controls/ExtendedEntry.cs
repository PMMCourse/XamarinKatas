using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_UI.Kata_j.Controls
{
    public class ExtendedEntry: Entry
    {
        public static BindableProperty BorderThicknessProperty = BindableProperty.Create(nameof(BorderThickness), typeof(int), typeof(ExtendedEntry), 0);
        public static BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(ExtendedEntry), Color.Transparent);
        public Color BorderColor
        {
            get =>(Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }
        public int BorderThickness {
            get => (int)GetValue(BorderThicknessProperty);
            set => SetValue(BorderThicknessProperty, value);
        }
    }
}
