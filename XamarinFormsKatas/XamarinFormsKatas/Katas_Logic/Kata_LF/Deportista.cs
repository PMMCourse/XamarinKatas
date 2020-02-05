using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_Logic.Kata_LF
{
    public class Deportista
    {
        public int Puntos { get; set; }
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public string Deporte { get; set; }

        public Deportista(int puntos,int edad,string nombre,string deporte)
        {
            this.Puntos = puntos;
            this.Edad = edad;
            this.Nombre = nombre;
            this.Deporte = deporte;
        }
        public Deportista()
        {

        }
    }
}
