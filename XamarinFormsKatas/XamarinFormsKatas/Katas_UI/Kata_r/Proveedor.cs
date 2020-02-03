using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    public class Proveedor:Persona
    {
        public string nombre;
        public string producto;

        public Proveedor(string nombre, string producto)
        {
            this.nombre = nombre;
            this.producto = producto;
        }
    }
}
