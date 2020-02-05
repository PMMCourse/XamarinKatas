using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
    public class deportista
    {
        public int puntuacion { get; set; }
        public int edad { get; set; }
        public String sexo { get; set; }
        public String deporte { get; set; }

        public deportista(int puntos, int edad,string sexo,string deporte)
        {
            this.puntuacion = puntos;
            this.edad = edad;
            this.sexo = sexo;
            this.deporte = deporte;
        }
        public deportista()
        {

        }
        public override string ToString()
        {
            return $"Puntos: {puntuacion}, edad: {edad}, sexo: {sexo}, deporte: {deporte}";
        }

    }
}
