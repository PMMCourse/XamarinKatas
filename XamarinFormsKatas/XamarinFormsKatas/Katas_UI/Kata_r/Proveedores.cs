using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    class Proveedores
    {
        public string Nombre { get; set; }
        public string Producto { get; set; }

        public override string ToString()
        {
            return $"Proveedor: {Nombre}, Producto: {Producto}";
        }
    }
}
