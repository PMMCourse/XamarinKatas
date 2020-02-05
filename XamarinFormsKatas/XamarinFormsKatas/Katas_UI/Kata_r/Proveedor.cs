using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
   public class Proveedor
    {
        public string nombre { get; set; }
        public string producto { get; set; }

        public override string ToString()
        {
            "Nombre producto" + nombre + "Producto" + producto;
        }
    }
}
