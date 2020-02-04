using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r.Model
{
    public class Cliente :Persona
    {
        public string Nom { get; set; }
        public string Dni { get; set; }

        public Cliente(string nom,string dni)
        {
            this.Nom = nom;
            this.Dni = dni;
        }
    }
}
