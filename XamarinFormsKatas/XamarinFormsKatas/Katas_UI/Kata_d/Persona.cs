using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
   public class Persona
    {
        public Persona(string nombre, string edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string Nombre { get; set; }
            public string Edad { get; set; }
            public override string ToString()
            {
                return Nombre;
            }
        }
    }

