using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
   public class Persona
    {
        public List<Persona> _listaP { get; set; }
        public int age { get; set; }
        public string name { get; set; }

        public Persona(int age, string name)
        {
            age = age;
            name = name;
        }
        public Persona()
        {
            _listaP = new List<Persona>();
            personasLista();
        }

        private void personasLista()
        {
            _listaP.Add(new Persona { age = 875, name = "Joaquin" });
            _listaP.Add(new Persona { age = 398, name = "Dani" });
            _listaP.Add(new Persona { age = 123, name = "Pepe" });
        }
    }
}
