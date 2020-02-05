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
		public List<Deportista> deporList = new List<Deportista>();
		public KataT ()
		{
			InitializeComponent ();

			var d1 = new Deportista() { Deporte = "Voleyball", Sexo = "No binario", Puntuacion = 1, Edad = 19 };
			var d2 = new Deportista() { Deporte = "Baloncesto", Sexo = "Hombre blanco Cis genero", Puntuacion = 3, Edad = 18 };

			deporList.Add(d1);
			deporList.Add(d2);

			listview.ItemsSource = deporList;
		}
	}
}