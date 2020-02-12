using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_t {
    public class Deportista {
        public int Puntuacion { get; set; }
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public string Deporte { get; set; }

        public Deportista(int puntuacion, int edad, string nombre, string deporte) {
            Puntuacion = puntuacion;
            Nombre = nombre;
            Deporte = deporte;
            Edad = edad;
        }

        public string Tostring {
            get {
                return $"Puntuacion: {Puntuacion}, Edad: {Edad}, Nombre: {Nombre}, Deporte: {Deporte}";
            }
        }
    }
}
