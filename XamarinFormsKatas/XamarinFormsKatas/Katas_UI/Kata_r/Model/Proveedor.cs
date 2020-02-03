using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    public class Proveedor:Persona
    {
        public string nombre { get; set; }
        public string producto { get; set; }

        public Proveedor(string nombre, string producto)
        {
            this.nombre = nombre;
            this.producto = producto;
        }
    }
}
