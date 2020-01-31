using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    public class Cliente
    {
        public string nombre { get; set; }
        public string  dni { get; set; }
        public Cliente(string nombre,string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
        public Cliente()
        {

        }
        public override string ToString()
        {
            return $"Cliente: {nombre}, dni: {dni} ";
        }
    }
}
