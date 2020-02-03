using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    public class Cliente: Persona
    {
        public string nombre;
        public string dni;

        public Cliente(string nombre,string dni) {
            this.nombre = nombre;
            this.dni = dni;
        }
    }
}
