using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_d {
    class Persona {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad) {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public string ToString {
            get {
                return $" Nombre: {Nombre}, Edad: {Edad}";
            }
        }
    }
}
