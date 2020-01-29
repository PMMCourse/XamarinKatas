using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
    public class Persona
    {
        public int edad { get; set; }
        public string nombre { get; set; }

        public Persona(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }
    }
}
