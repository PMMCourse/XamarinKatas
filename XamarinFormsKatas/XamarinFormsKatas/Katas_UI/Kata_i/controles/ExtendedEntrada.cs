using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_UI.Kata_i.controles
{
    public class ExtendedEntrada:Entry
    {
        public static BindableProperty borderThickness = BindableProperty.Create(nameof(thickness), typeof(int), typeof(ExtendedEntrada), 0);
        public static BindableProperty boderColor = BindableProperty.Create(nameof(color), typeof(Color), typeof(ExtendedEntrada), Color.Transparent);
        public Color color
        {
            get => (Color)GetValue(boderColor);
            set => SetValue(boderColor, value);
        }
        public int thickness
        {
            get => (int)GetValue(borderThickness);
            set => SetValue(borderThickness, value);
        }
    }
}
