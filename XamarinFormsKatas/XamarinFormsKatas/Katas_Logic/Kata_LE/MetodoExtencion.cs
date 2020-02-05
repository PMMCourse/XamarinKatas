using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XamarinFormsKatas.Katas_Logic.Kata_LE
{
    public static class MetodoExtencion
    {
        public static Color Mexcla(this Color c1,Color c2,Color c3)
        {
            byte b = (byte)(c1.A + c2.A + c3.A);
            byte b2 = (byte)(c1.R);
            byte b3 = (byte)(c1.G);
            byte b4 = (byte)(c1.B);
            return Color.FromArgb(b, b2, b3, b4) ;
        }
    }
}
