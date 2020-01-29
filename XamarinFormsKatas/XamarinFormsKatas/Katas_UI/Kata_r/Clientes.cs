using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    class Clientes
    {
        public string Nombre { get; set; }
        public string Dni { get; set; }

        public override string ToString()
        {
            return $"Cliente: {Nombre}, Dni: {Dni}";
        }
    }
}
