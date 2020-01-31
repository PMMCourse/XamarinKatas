using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
    public class Deportista
    {
        public double Puntuacion { get; set; }
        public string Nombre { get; set; }
        public string Deporte { get; set; }
        public int Edad { get; set; }
        public string MostrarCadena
        { get
            {
                return $"Nombre: {Nombre}, Edad: {Edad}, Deporte: {Deporte}, Puntuacion: {Puntuacion}.";
            }
        }

        public Deportista()
        {
        }

        public Deportista(double puntuacion, string nombre, string deporte, int edad)
        {
            Puntuacion = puntuacion;
            Nombre = nombre;
            Deporte = deporte;
            Edad = edad;
        }
    }
}
