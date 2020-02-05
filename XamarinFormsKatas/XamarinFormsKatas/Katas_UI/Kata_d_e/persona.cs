using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_UI.Kata_d_e
{
    public class persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }

    }

    public class ListaPersona
    {
        public List<persona> _personas { get; set; }
        
        public ListaPersona()
        {
            _personas = new List<persona>();
            anadirPersona();
        }

        public void anadirPersona()
        {
            _personas.Add(new persona
            {
                nombre = "Juan Carlos",
                edad = 22

            });

            _personas.Add(new persona
            {
                nombre = "Cueto",
                edad = 22

            });

            _personas.Add(new persona
            {
                nombre = "Juanki",
                edad = 24

            });
        }
    }
}
