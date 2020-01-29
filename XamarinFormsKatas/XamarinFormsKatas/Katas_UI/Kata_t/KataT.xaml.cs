using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataT : ContentPage
	{
        List<Deportista> listaDeportistas = new List<Deportista>();
 
		public KataT ()
		{
			InitializeComponent ();

            RellenarLista();

            ListaLV.ItemsSource = listaDeportistas;         
		}

        private void RellenarLista()
        {
            listaDeportistas.Add(new Deportista(500,"David","Baloncesto",34));
            listaDeportistas.Add(new Deportista(700, "Pedro", "Tenis", 27));
            listaDeportistas.Add(new Deportista(300, "Andres", "Futbol", 37));
            listaDeportistas.Add(new Deportista(1000, "Jose Manuel", "Futbol", 24));
            listaDeportistas.Add(new Deportista(800, "Fernando", "Baloncesto", 21));
        }

	}
}