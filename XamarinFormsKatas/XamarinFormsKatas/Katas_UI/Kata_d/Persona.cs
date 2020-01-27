using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
    public class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public string image { get; set; }

        public string Tostring
        {
            get
            {
                return $" Nombre: {Nombre},  Edad: {Edad}";
            }
        }
    }
}
