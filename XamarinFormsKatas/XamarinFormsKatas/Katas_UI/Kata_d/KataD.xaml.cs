using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataD : ContentPage
	{
        List<Persona> listaPersonas = new List<Persona>();

        public KataD ()
		{
			InitializeComponent ();
            InsertarPersonas();

            ListaPersonas.ItemsSource = listaPersonas;
		}

        private void InsertarPersonas()
        {
            listaPersonas.Add(new Persona("Persona 1", 22));
            listaPersonas.Add(new Persona("Persona 2", 23));
            listaPersonas.Add(new Persona("Persona 3", 24));
            listaPersonas.Add(new Persona("Persona 4", 25));
            listaPersonas.Add(new Persona("Persona 5", 26));     
        }
	}
}