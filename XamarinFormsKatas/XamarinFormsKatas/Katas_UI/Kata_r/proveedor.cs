using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    public class proveedor
    {
        public string nombre { get; set; }
        public string Producto { get; set; }
        public proveedor(String nombre, string producto)
        {
            this.nombre = nombre;
            this.Producto = producto;
        }
        public proveedor()
        {

        }
        public override string ToString()
        {
            return $"proveedor: {nombre}, producto: {Producto}";

        }
    }
}
