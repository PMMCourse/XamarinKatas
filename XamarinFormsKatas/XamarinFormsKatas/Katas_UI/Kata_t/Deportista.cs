﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
    public class Deportista
    {
        public int Puntuacion { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Deporte { get; set; }
        public string Tostring
        {
            get
            {
                return $"Puntuacion: {Puntuacion}, Edad: {Edad}, Sexo: {Sexo}, Deporte: {Deporte}";
            }
        }
    }
}
