using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_e
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public Persona()
        {
        }
    }
}
