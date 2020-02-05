using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_f
{
    public class Personas
    {
        public int edad { get; set; }
        public string nombre { get; set; }
        public Personas(int edad,string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }
        public Personas()
        {

        }
    }
}
