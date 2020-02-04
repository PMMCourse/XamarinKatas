using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
   public class Cliente
    {
        public string dni { get; set; }
        public string nombre { get; set; }

        public override string ToString()
        {
            "Nombre cliente" + nombre + "DNI cliente" + dni; 
        }
    }
}
