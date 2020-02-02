using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XamarinFormsKatas.Katas_Logic.Kata_LE
{
    public static class ExtensionMethod
    {
        public static Color Blend(this Color color1, Color color2, Color color3)
        {
            byte a = (byte)(color1.A + color2.A + color3.A);
            byte r = (byte)(color1.R);
            byte g = (byte)(color1.G);
            byte b = (byte)(color1.B);
            return Color.FromArgb(a, r, g, b);
        }
    }
}
