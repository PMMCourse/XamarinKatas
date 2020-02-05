using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_t.Model
{
    public class Deportista
    {
        public Deportista()
        {
        }

        public Deportista(string nom, string deporte, int puntuacion, int edad)
        {
            this.nom = nom;
            this.deporte = deporte;
            this.puntuacion = puntuacion;
            this.edad = edad;
        }

        public string nom { get; set; }
        public string deporte{get;set;}
        public int puntuacion { get; set; }
        public int edad { get; set; }


    }
}
