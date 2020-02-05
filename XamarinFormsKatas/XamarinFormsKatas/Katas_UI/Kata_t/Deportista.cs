using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
    class Deportista
    {
        private string puntuacion;
        private string nombre;
        private string deporte;
        private byte edad;

        public Deportista(string puntuacion, string nombre, string deporte, byte edad)
        {
            this.Puntuacion = puntuacion;
            this.Nombre = nombre;
            this.Deporte = deporte;
            this.Edad = edad;
        }

        public string Puntuacion { get => puntuacion; set => puntuacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Deporte { get => deporte; set => deporte = value; }
        public byte Edad { get => edad; set => edad = value; }
    }
}
