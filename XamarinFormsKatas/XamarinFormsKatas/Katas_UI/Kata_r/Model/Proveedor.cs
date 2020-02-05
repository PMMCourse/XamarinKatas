using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_r.Model
{
    public class Proveedor:Persona
    {
        public string Nom { get; set; }
        public string ProductName { get; set; }

        public Proveedor(string nom,string product)
        {
            this.Nom = nom;
            this.ProductName = product;
        }
    }
}
