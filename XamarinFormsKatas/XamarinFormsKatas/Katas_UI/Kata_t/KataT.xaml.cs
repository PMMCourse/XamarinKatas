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
		public List<Deportista> _listaDeportes { get; set; }
		public KataT ()
		{
			InitializeComponent ();
		}
		public Deportista()
		{
			_listaDeportes = new List<Deportista>();
			introduceList();
		}

		private void introduceList()
		{
			_listaDeportes.Add(new Deportista { Deporte = "Tenis", Edad = 54, Puntuacion = 123, Sexo = "Hombre" });
			_listaDeportes.Add(new Deportista { Deporte = "Baloncesto", Edad = 28, Puntuacion = 453, Sexo = "Mujer" });
			_listaDeportes.Add(new Deportista { Deporte = "Fútbol", Edad = 23, Puntuacion = 379, Sexo = "Hombre" });
		}

	}
}