using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
   public class Deportista
    {
        public string Sexo { get; set; }
        public string Deporte { get; set; }
        public int Edad { get; set; }
        public int Puntuacion { get; set; }

        public string ReturnList
        {
            get
            {
                return "Sexo"+ Sexo + "Puntuacion" + Puntuacion + "Deporte" + Deporte + "Edad" + Edad;             
            }
        }
    }
}
