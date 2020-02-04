using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_Logic.Kata_LF.Model
{
    public class Deportista
    {
        public int puntuacion { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string deporte { get; set; }
        public Deportista(int puntuacion, string nombre, int edad, string deporte)
        {
            this.puntuacion = puntuacion;
            this.nombre = nombre;
            this.edad = edad;
            this.deporte = deporte;
        }
        public Deportista() { }
    }
}
