using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
    public class Deportista
    {
        public int puntuacion;
        public string nombre;
        public int edad;
        public string deporte;
        public Deportista(int puntuacion, string nombre, int edad, string deporte) {
            this.puntuacion = puntuacion;
            this.nombre = nombre;
            this.edad = edad;
            this.deporte = deporte;
        }
    }
}
