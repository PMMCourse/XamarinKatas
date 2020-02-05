using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_e
{
   public class Persona
    {
        public Persona(string nombre, string edad, string foto)
        {
            Nombre = nombre;
            Edad = edad;
            Foto = foto;
        }

        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Foto { get; set; }
        public override string ToString()
            {
                return $" La persona llamada: {Nombre} tiene: {Edad} años";
            }
        }
    }

