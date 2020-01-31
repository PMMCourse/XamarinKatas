using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    public class proveedores
    {
        public string  nombre { get; set; }
        public string Producto { get; set; }
        public proveedores(String nombre,string producto)
        {
            this.nombre = nombre;
            this.Producto = producto;
        }
        public proveedores()
        {

        }
        public override string ToString()
        {
            return $"proveedor: {nombre}, producto: {Producto}";

        }
    }
}
