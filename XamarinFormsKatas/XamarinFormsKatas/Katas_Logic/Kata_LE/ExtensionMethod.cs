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
            byte r = (byte)(color1.R + color2.R + color3.R);
            byte g = (byte)(color1.G + color2.G + color3.G);
            byte b = (byte)(color1.B + color2.B + color3.B);
            return Color.FromArgb(r, g, b);
        }
    }
}
